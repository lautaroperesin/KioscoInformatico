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
    public partial class HistoricoVentasViewReport : Form
    {
        ReportViewer reporte;
        List<Venta> listaVentas;
        string tituloReporte;
        public HistoricoVentasViewReport(List<Venta> ventas, string titulo)
        {
            InitializeComponent();
            listaVentas = ventas;
            this.tituloReporte = titulo;
            reporte = new ReportViewer();
            reporte.Dock = DockStyle.Fill;
            Controls.Add(reporte);
        }

        private void HistoricoVentasViewReport_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "KioscoInformaticoDesktop.Reports.HistoricoVentasReport.rdlc";

            var ventas = listaVentas
                .OrderBy(v => v.FormaPago)
                .Select(venta => new
                { 
                    Id = venta.Id,
                    Fecha = venta.Fecha,
                    ClienteNombre = venta.Cliente.Nombre,
                    Total = venta.Total, 
                    IVA = venta.Iva, 
                    FormaPago = venta.FormaPago.ToString() 
                })
                .ToList();

            reporte.LocalReport.SetParameters(new ReportParameter("TituloReporte", tituloReporte));
            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSVentas", ventas));
            reporte.SetDisplayMode(DisplayMode.PrintLayout);
            reporte.RefreshReport();
        }
    }
}
