using CommunityToolkit.Mvvm.Messaging;
using KioscoInformaticoApp.Class;
using KioscoInformaticoApp.ViewModels;

namespace KioscoInformaticoApp.Views;

public partial class InicioSesionView : ContentPage
{
	public InicioSesionView()
	{
		InitializeComponent();

        WeakReferenceMessenger.Default.Register<Message>(this, (r, mensaje) =>
        {
            OnReceiveMessage(mensaje);
        });
    }

    private async void OnReceiveMessage(Message mensaje)
    {
        if (mensaje.Value == "AbrirProductos")
        {
            await Navigation.PushAsync(new ProductosView());
        }
        if (mensaje.Value == "AbrirOfertas")
        {
            await Navigation.PushAsync(new ProductosOfertaView());
        }
        if(mensaje.Value == "AgregarProducto")
        {
            await Navigation.PushAsync(new AgregarEditarProductoView());
        }
        if(mensaje.Value == "CerrarVentana")
        {
            await Navigation.PopAsync();
        }
    }
}