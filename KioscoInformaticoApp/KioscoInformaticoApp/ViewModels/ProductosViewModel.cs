﻿using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoServices.Models;
using KioscoInformaticoServices.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoApp.ViewModels
{
    public class ProductosViewModel : ObjectNotification
    {
		private ProductoService productService= new ProductoService();
        private string filterProducts;

		public string FilterProducts
		{
			get { return filterProducts; }
			set { filterProducts = value;
                OnPropertyChanged();
                FiltrarProductos();
            }
		}

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set
            {
                _isRefreshing = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Producto> products;

		public ObservableCollection<Producto> Products
		{
			get { return products; }
			set { products = value;
			OnPropertyChanged();
            }
		}

        private List<Producto>? productListToFilter;

        public Command GetProductsCommand { get; }
		public Command FilterProductsCommand { get; }
        public Command AddProductCommand { get; }

        public ProductosViewModel()
        {
            GetProductsCommand = new Command(async () => await GetProducts());
            //GetProductsInOffer = new Command(async () => await GetProductsInOffer());
            FilterProductsCommand = new Command(async () => await FiltrarProductos());
            AddProductCommand = new Command(async () => await AddProduct());
            GetProducts();
        }

        private async Task AddProduct()
        {
            WeakReferenceMessenger.Default.Send(new Message("AgregarProducto"));
        }

        private async Task FiltrarProductos()
        {
            var productsLeaked = productListToFilter.Where(p => p.Nombre.ToLower().Contains(filterProducts.ToLower())).ToList();
            Products = new ObservableCollection<Producto>(productsLeaked);
        }   

        public async Task GetProducts()
        {
            FilterProducts = string.Empty;
            IsRefreshing = true;
            productListToFilter = await productService.GetAllAsync();
            Products = new ObservableCollection<Producto>(productListToFilter);
            IsRefreshing = false;
        }
    }
}
