using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp.Views;

public partial class ProductosOfertaView : ContentPage
{
	public ProductosOfertaView()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var viewmodel = this.BindingContext as ProductosOfertaViewModel;

        viewmodel.GetProducts();
    }
}