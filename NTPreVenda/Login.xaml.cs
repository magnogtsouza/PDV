using System.Diagnostics;

namespace NTPreVenda;

public partial class Login : ContentPage
{
    public Login()
    {
        InitializeComponent();
    }




    private void Login_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }
}