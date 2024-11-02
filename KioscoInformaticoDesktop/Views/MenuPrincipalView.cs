using KioscoInformaticoDesktop.ViewReports;
using KioscoInformaticoDesktop.Views;

namespace KioscoInformaticoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void menuItemSalirDelSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuItemLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesView localidadesView = new LocalidadesView();
            localidadesView.ShowDialog();
        }

        private void menuItemProductos_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }

        private void iconMenuClientes_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void iconMenuProveedores_Click(object sender, EventArgs e)
        {
            ProveedoresView proveedoresView = new ProveedoresView();
            proveedoresView.ShowDialog();
        }

        private void iconMenuLocalidades_Click(object sender, EventArgs e)
        {
            LocalidadesViewReport localidadesViewReport = new LocalidadesViewReport();
            localidadesViewReport.ShowDialog();
        }

        private void iconMenuListadoClientes_Click(object sender, EventArgs e)
        {
            ClientesViewReport clientesViewReport = new ClientesViewReport();
            clientesViewReport.ShowDialog();
        }

        private void iconMenuVentas_Click(object sender, EventArgs e)
        {
            VentasView ventasView = new VentasView();
            ventasView.ShowDialog();
        }

        private void iconToolHistoricoVentas_Click(object sender, EventArgs e)
        {
            HistoricoVentasView historicoVentasView = new HistoricoVentasView();
            historicoVentasView.ShowDialog();
        }

        private void iconMenuCompras_Click(object sender, EventArgs e)
        {
            ComprasView comprasView = new ComprasView();
            comprasView.ShowDialog();
        }
    }
}
