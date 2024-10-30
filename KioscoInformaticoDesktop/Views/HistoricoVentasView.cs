using KioscoInformaticoDesktop.ExtensionMethods;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;

namespace KioscoInformaticoDesktop.Views
{
    public partial class HistoricoVentasView : Form
    {
        GenericService<Venta> ventaService = new GenericService<Venta>();
        List<Venta> ventas = new List<Venta>();
        public HistoricoVentasView()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            ventas = await ventaService.GetAllAsync();
            DisplayDataGrid();
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (checkFiltrado.Checked)
            {
                numericTotalFacturado.Value = ventas.Where(venta => venta.Fecha >= dtpDesde.Value && venta.Fecha <= dtpHasta.Value).Sum(venta => venta.Total);
            }
            else
            {
                numericTotalFacturado.Value = ventas.Sum(venta=>venta.Total);
                }
        }

        private void DisplayDataGrid()
        {
            dataGridVentas.DataSource = ventas;
            dataGridVentas.OcultarColumnas(new string[] { "Id", "Eliminado", "ClienteId", "DetallesVenta" });
            dataGridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/mm/yyyy";
            dataGridVentas.Columns["Iva"].DefaultCellStyle.Format = "N2";
            dataGridVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
        
        }

        private void checkFiltrado_CheckedChanged(object sender, EventArgs e)
        {
            panelFiltrado.Enabled = checkFiltrado.Checked;
            if (checkFiltrado.Checked)
            {
                dtpDesde.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dtpHasta.Value = DateTime.Now;
                DisplayFilterData();
                CalcularTotal();
            }
            else
            {
                DisplayDataGrid();
                CalcularTotal();
            }
        }

        private void DisplayFilterData()
        {
            dataGridVentas.DataSource = ventas.Where(venta => venta.Fecha >= dtpDesde.Value && venta.Fecha <= dtpHasta.Value).ToList();
            dataGridVentas.OcultarColumnas(new string[] { "Id", "Eliminado", "ClienteId", "DetallesVenta" });
            dataGridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/mm/yyyy";
            dataGridVentas.Columns["Iva"].DefaultCellStyle.Format = "N2";
            dataGridVentas.Columns["Total"].DefaultCellStyle.Format = "N2";
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DisplayFilterData();
            CalcularTotal();
        }
    }
}
