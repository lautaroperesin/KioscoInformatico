using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoDesktop.ViewReports;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class VentasView : Form
    {
        ClienteService clienteService = new ClienteService();
        ProductoService productoService = new ProductoService();
        IGenericService<Venta> ventaService = new GenericService<Venta>();
        Venta venta = new Venta();

        public VentasView()
        {
            InitializeComponent();
            AjustePantalla();
        }

        private async void AjustePantalla()
        {
            #region Carga de combos
            await Task.WhenAll(
                Task.Run(async () => cboClientes.DataSource = await clienteService.GetAllAsync()),
                Task.Run(async () => cboProductos.DataSource = await productoService.GetAllAsync())
                );

            cboClientes.DisplayMember = "Nombre";
            cboClientes.ValueMember = "Id";

            cboProductos.DisplayMember = "Nombre";
            cboProductos.ValueMember = "Id";
            cboProductos.SelectedIndex = -1;

            cboFormaPago.DataSource = Enum.GetValues(typeof(FormaDePagoEnum));
            #endregion

            numericPrecio.Value = 0;
            numericCantidad.Value = 1;
            gridDetallesVenta.DataSource = venta.DetallesVenta.ToList();
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProductos.SelectedIndex != -1)
            {
                Producto producto = (Producto)cboProductos.SelectedItem;
                numericPrecio.Value = producto.Precio;
            }
            btnAgregar.Enabled = cboProductos.SelectedIndex != -1;
        }

        private void numericCantidad_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void numericPrecio_ValueChanged(object sender, EventArgs e)
        {
            numericSubtotal.Value = numericPrecio.Value * numericCantidad.Value;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var detalleVenta = new DetalleVenta
            {
                Producto = (Producto)cboProductos.SelectedItem,
                ProductoId = (int)cboProductos.SelectedValue,
                Cantidad = (int)numericCantidad.Value,
                PrecioUnitario = numericPrecio.Value
            };
            venta.DetallesVenta.Add(detalleVenta);
            gridDetallesVenta.DataSource = venta.DetallesVenta.ToList();
            cboProductos.SelectedIndex = -1;
            cboProductos.Focus();
            ActualizarTotalFactura();
        }

        private void ActualizarTotalFactura()
        {
            numericTotal.Value = venta.DetallesVenta.Sum(dv => dv.Subtotal);
        }

        private void gridDetallesVenta_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            gridDetallesVenta.OcultarColumnas(new string[] { "Id", "VentaId", "ProductoId", "Eliminado", "Venta" });
            btnQuitar.Enabled = gridDetallesVenta.RowCount > 0;
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (gridDetallesVenta.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un detalle de venta");
                return;
            }
            var detalleVenta = (DetalleVenta)gridDetallesVenta.CurrentRow.DataBoundItem;
            venta.DetallesVenta.Remove(detalleVenta);
            gridDetallesVenta.DataSource = venta.DetallesVenta.ToList();
            ActualizarTotalFactura();
        }

        private async void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            var ventaTemp = venta;
            ventaTemp.ClienteId = (int)cboClientes.SelectedValue;
            ventaTemp.Fecha = DateTime.Now;
            ventaTemp.FormaPago = (FormaDePagoEnum)cboFormaPago.SelectedItem;
            ventaTemp.Total = numericTotal.Value;
            ventaTemp.Iva = venta.Total * 0.21m;

            ventaTemp.Cliente = null;
            ventaTemp.DetallesVenta.ToList().ForEach(dv => dv.Producto = null);
            ventaTemp.DetallesVenta.ToList().ForEach(dv => dv.Venta = null);
            var nuevaVenta = await ventaService.AddAsync(venta);
            var facturaVenta = new FacturaVentaViewReport(nuevaVenta);
            facturaVenta.ShowDialog();
        }
    }
}
