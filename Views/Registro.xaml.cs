namespace abustillosS3B.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

	private void btnGuardar_Clicked(object sender, EventArgs e)
	{
		string usuario = txtUsuarior.Text;
		string contrase�a = txtContrase�ar.Text;

		Navigation.PushAsync(new Views.Login(usuario, contrase�a));
    }
}