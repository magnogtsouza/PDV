using Microsoft.Data.SqlClient;
using NTPreVenda.db.Models;
using NTPreVenda.Models;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace NTPreVenda
{
    public partial class MainPage : ContentPage
    {
        private bool SomenteMinhasVendas = false;
        public Vendedor SelecTedVendedor = null;

        public MainPage()
        {
            InitializeComponent();
            GetVendas();
            pkVendedor.ItemsSource = VarGlobais.Vendedores;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PushAsync(new Login(), true);
        }
        public bool Waiting = false;
        private async void GetVendas(bool CurrentVendedor = false)
        {
            while (Waiting)
            {
                await Task.Delay(500);
            }
            Waiting = true;
            try
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                IDictionary<string, string> Condition = new Dictionary<string, string>();
                if (CurrentVendedor && SelecTedVendedor != null)
                {
                    Condition.Add("DAV_VENDEDOR", SelecTedVendedor.VEN_CODIGO);
                }
                List<PreVenda> preVendas = await new PreVenda().GetList(25, Condition) as List<PreVenda>;
                for (int i = 0; i < preVendas.Count(); i++)
                {
                    Vendedor locVendedor = VarGlobais.Vendedores.Where(x => x.VEN_CODIGO.Equals(preVendas[i].DAV_VENDEDOR)).FirstOrDefault();
                    preVendas[i].NomeVendedor = locVendedor == null ? preVendas[i].DAV_VENDEDOR : locVendedor.VEN_NOME.Trim();
                }
                stopwatch.Stop();
                lwVendas.ItemsSource = preVendas;
            }
            catch (Exception e)
            {
                await DisplayAlert("Erro", e.Message, "OK");
            }
            finally
            {
                Waiting = false;
            }
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            SomenteMinhasVendas = e.Value;
            GetVendas(e.Value);
        }

        private void pkVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Picker pk = (sender as Picker);
            if (pk.SelectedIndex > -1)
            {
                Vendedor v = (sender as Picker).SelectedItem as Vendedor;
                SelecTedVendedor = v;
            }
            else
            {
                SelecTedVendedor = null;
            }
            if (!SomenteMinhasVendas)
            {
                GetVendas(SomenteMinhasVendas);
            }

        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PushAsync(new PrevendaView(SelecTedVendedor), true);
        }

        private async void lwVendas_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            PreVenda pre = e.Item as PreVenda;
            await Shell.Current.Navigation.PushAsync(new PrevendaView(SelecTedVendedor, pre), true);
            return;
        }
    }

}
