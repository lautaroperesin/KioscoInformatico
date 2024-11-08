using KioscoInformaticoApp.ViewModels;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Views;

[QueryProperty(nameof(Product), "ProductoAEditar")]
public partial class AddEditProductoView : ContentPage
{
    public Producto Product
    {
        set
        {
            var producto = value;
            var viewModel = this.BindingContext as AgregarEditarProductoViewModel;
            viewModel.EditProduct = producto;
        }
    }

    public AddEditProductoView()
    {
        InitializeComponent();
    }

    public AddEditProductoView(Producto productoAEditar)
	{
		InitializeComponent();
        var viewModel = this.BindingContext as AgregarEditarProductoViewModel;
        viewModel.EditProduct = productoAEditar;
    }
}