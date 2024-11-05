using KioscoInformaticoServices.Models;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.ViewReports
{
    public partial class FacturaCompraViewReport : Form
    {
        ReportViewer reporte;
        private Compra? nuevaCompra;
        public FacturaCompraViewReport(Compra? nuevaCompra)
        {
            InitializeComponent();

            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);

            this.nuevaCompra = nuevaCompra;
        }

        private void FacturaCompraViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaCompraReport.rdlc";
            List<object> compra = new List<object> { new { Id = nuevaCompra.Id, Fecha = nuevaCompra.Fecha, ProveedorNombre = nuevaCompra.Proveedor.Nombre, Total = nuevaCompra.Total, IVA = nuevaCompra.Iva, FormaPago = nuevaCompra.FormaDePago.ToString() } };

            var detalleCompra = nuevaCompra.DetallesCompra.Select(detalle => new { ProductoNombre = detalle.Producto.Nombre, PrecioUnitario = detalle.PrecioUnitario, Cantidad = detalle.Cantidad, Subtotal = detalle.Subtotal });

            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSCompra", compra));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesCompra", detalleCompra));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
