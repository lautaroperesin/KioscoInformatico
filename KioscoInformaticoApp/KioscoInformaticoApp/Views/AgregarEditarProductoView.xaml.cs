using KioscoInformaticoApp.ViewModels;
using KioscoInformaticoServices.Models;

namespace KioscoInformaticoApp.Views;

public partial class AgregarEditarProductoView : ContentPage
{
	public AgregarEditarProductoView(Producto productoAEditar)
	{
		InitializeComponent();
        var viewModel = this.BindingContext as AgregarEditarProductoViewModel;
        viewModel.EditProduct = productoAEditar;
    }
}