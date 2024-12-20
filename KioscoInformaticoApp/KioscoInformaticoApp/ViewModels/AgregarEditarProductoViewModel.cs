﻿using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
	public class AgregarEditarProductoViewModel : ObjectNotification
	{
		ProductoService productoService = new ProductoService();
		private Producto editProduct;

		public Producto EditProduct
		{
			get { return editProduct; }
			set
			{
				editProduct = value;
				OnPropertyChanged();
				SettingData();
			}
		}

		private void SettingData()
		{
			if(editProduct != null)
			{
                Nombre = editProduct.Nombre;
                Precio = editProduct.Precio;
                Oferta = editProduct.Oferta;
            }
			else
			{
                Nombre = string.Empty;
                Precio = 0;
                Oferta = false;
				return;
            }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set
			{
				nombre = value;
				OnPropertyChanged();
			}
		}

		private decimal precio;

		public decimal Precio
		{
			get { return precio; }
			set
			{
				precio = value;
				OnPropertyChanged();
			}
		}

		private bool oferta;

		public bool Oferta
		{
			get { return oferta; }
			set
			{
				oferta = value;
				OnPropertyChanged();
			}
		}

		public Command SaveProductCommand { get; }

		public AgregarEditarProductoViewModel()
		{
			SaveProductCommand = new Command(async () => await SaveProduct());
		}

		private async Task SaveProduct()
		{
			if (EditProduct != null)
			{
				editProduct.Nombre = Nombre;
				editProduct.Precio = Precio;
				editProduct.Oferta = Oferta;
				await productoService.UpdateAsync(editProduct);
			}
			else
			{
				var producto = new Producto()
				{
					Nombre = Nombre,
					Precio = Precio,
					Oferta = Oferta
				};
				await productoService.AddAsync(producto);
			}
			await Shell.Current.GoToAsync("//ListaProductos");
        }
	}
}
