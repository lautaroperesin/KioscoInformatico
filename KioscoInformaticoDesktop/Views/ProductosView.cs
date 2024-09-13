﻿using KioscoInformaticoServices.Interfaces;
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
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class ProductosView : Form
    {
        IGenericService<Producto> productoService = new GenericService<Producto>();

        BindingSource listaProductos = new BindingSource();

        Producto productoCurrent;
        public ProductosView()
        {
            InitializeComponent();
            dataGridProductos.DataSource = listaProductos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            listaProductos.DataSource = await productoService.GetAllAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPageAgregarEditar;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre es requerido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (productoCurrent != null)
            {
                productoCurrent.Nombre = txtNombre.Text;
                await productoService.UpdateAsync(productoCurrent);
                productoCurrent = null;
            }
            else
            {
                Producto producto = new Producto()
                {
                    Nombre = txtNombre.Text
                };
                await productoService.AddAsync(producto);
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            tabControl1.SelectedTab = tabPageLista;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            productoCurrent = (Producto)listaProductos.Current;
            txtNombre.Text = productoCurrent.Nombre;
            tabControl1.SelectedTab = tabPageAgregarEditar;
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            productoCurrent = (Producto)listaProductos.Current;
            DialogResult respuesta = MessageBox.Show($"Está seguro que quiere eliminar el producto {productoCurrent.Nombre}?",
                                   "Eliminar producto",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await productoService.DeleteAsync(productoCurrent.Id);
                productoCurrent = null;
                await CargarGrilla();
            }
        }
    }
}
