using NTPreVenda.Models;

namespace NTPreVenda
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;
        PreVendaOrc[] vendas;
        public MainPage()
        {
            InitializeComponent();
            vendas = new PreVendaOrc[3];
            vendas[0] = new PreVendaOrc { Id = 0001, Valor = 900, Vendedor = "janmes" , Cliente = "Roberto"};
            vendas[1] = new PreVendaOrc { Id = 0005, Valor = 102.50, Vendedor = "Ruliam" ,Cliente = "Magno" };
            vendas[2] = new PreVendaOrc { Id = 0023, Valor = 25.50, Vendedor = "Francis", Cliente = "Luzinet" };
            lwVendas.ItemsSource = vendas;
            //Shell.Current.GoToAsync("//Login");
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
           /* count++;
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";
            SemanticScreenReader.Announce(CounterBtn.Text);*/
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PushAsync(new Login(),true);
        }
    }

}
