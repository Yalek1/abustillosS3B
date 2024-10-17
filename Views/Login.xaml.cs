namespace abustillosS3B.Views;

public partial class Login : ContentPage
{
    string user = "x";
    string pass = "x";

	public Login()
	{
		InitializeComponent();
	}

    public Login(string usuario, string contrase�a)
    {
        InitializeComponent();

        user = usuario;
        pass = contrase�a;
    }

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        if (user == txtUsuario.Text && pass == txtContrase�a.Text)
        {
            Navigation.PushAsync(new Views.Home());
        }
        else
        {
            DisplayAlert("ERROR", "Usuario o contrase�a incorrectos", "CERRAR");
        }
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Views.Registro());
    }
}