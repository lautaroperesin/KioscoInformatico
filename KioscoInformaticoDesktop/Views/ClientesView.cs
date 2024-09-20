using KioscoInformaticoServices.Interfaces;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ClientesView : Form
    {
        IClienteService clienteService = new ClienteService();
        BindingSource listaClientes = new BindingSource();
        Cliente clienteCurrent;
        public ClientesView()
        {
            InitializeComponent();
            dataGridLocalidades.DataSource = listaClientes;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            listaClientes.DataSource = await clienteService.GetAllAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControlLista.SelectedTab = tabPageAgregarEditar;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clienteCurrent != null)
            {
                clienteCurrent.Nombre = txtNombre.Text;
                await clienteService.UpdateAsync(clienteCurrent);
                clienteCurrent = null;
            }
            else
            {
                Cliente cliente = new Cliente()
                {
                    Nombre = txtNombre.Text
                };
                await clienteService.AddAsync(cliente);
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            tabControlLista.SelectedTab = tabPageLista;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)listaClientes.Current;
            txtNombre.Text = clienteCurrent.Nombre;
            tabControlLista.SelectedTab = tabPageAgregarEditar;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            clienteCurrent = (Cliente)listaClientes.Current;
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar el cliente {clienteCurrent.Nombre}?",
                                   "Eliminar cliente",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await clienteService.DeleteAsync(clienteCurrent.Id);
                clienteCurrent = null;
                await CargarGrilla();
            }
        }

        private async void FiltrarClientes()
        {
            listaClientes.DataSource = await clienteService.GetAllAsync(txtBuscar.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarClientes();
        }
    }
}
