using KioscoInformaticoServices.Interfaces;
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
    public partial class FacturaVentaViewReport : Form
    {
        ReportViewer reporte;
        private Venta? nuevaVenta;

        public FacturaVentaViewReport()
        {
            InitializeComponent();

            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);
        }

        public FacturaVentaViewReport(Venta? nuevaVenta)
        {
            InitializeComponent();

            reporte = new ReportViewer();

            reporte.Dock = DockStyle.Fill;

            Controls.Add(reporte);

            this.nuevaVenta = nuevaVenta;
        }

        private void FacturaVentaViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.FacturaVentaReport.rdlc";
            List<object> venta = new List<object> { new { Id = nuevaVenta.Id, Fecha = nuevaVenta.Fecha, ClienteNombre = nuevaVenta.Cliente.Nombre, Total = nuevaVenta.Total, Iva = nuevaVenta.Iva, FormaPago = nuevaVenta.FormaPago } };



            var detalleVenta = nuevaVenta.DetallesVenta.Select(detalle => new { ProductoNombre = detalle.Producto.Nombre, PrecioUnitario = detalle.PrecioUnitario, Cantidad = detalle.Cantidad, Subtotal = detalle.Subtotal });


            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVenta", venta));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesVenta", detalleVenta));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
