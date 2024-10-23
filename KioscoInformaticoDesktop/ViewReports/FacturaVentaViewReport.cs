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
            var venta = new { Id = nuevaVenta?.Id, Fecha = nuevaVenta?.Fecha, ClienteNombre = nuevaVenta?.Cliente.Nombre, FormaPago = nuevaVenta?.FormaPago, IVA = nuevaVenta?.Iva };
            var detallesVenta = nuevaVenta?.DetallesVenta.Select(dv => new { ProductoNombre = dv.Producto.Nombre, Cantidad = dv.Cantidad, PrecioUnitario = dv.PrecioUnitario, Subtotal = dv.Subtotal });

            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVenta", venta));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDetallesVenta", detallesVenta));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.RefreshReport();
        }
    }
}
