using Microsoft.Data.SqlClient;
using NTPreVenda.db.Models;
using NTPreVenda.Models;
using System.Diagnostics;

namespace NTPreVenda
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //_ = VarGlobais.RefreshCache().Result;
            //db.Models.PreVenda s = new db.Models.PreVenda();
            GetVendas();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Shell.Current.Navigation.PushAsync(new Login(), true);
        }

        private async void GetVendas()
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            if (VarGlobais.Vendedores == null || VarGlobais.Vendedores.Length == 0)
            {
                List<Vendedor> vendedors = await new Vendedor().GetList() as List<Vendedor>;
                VarGlobais.Vendedores = vendedors.ToArray();
            } 
            List<PreVenda> preVendas = await new PreVenda().GetList() as List<PreVenda>;

            for (int i = 0; i < preVendas.Count(); i++)
            {
                Vendedor locVendedor = VarGlobais.Vendedores.Where(x => x.VEN_CODIGO.Equals(preVendas[i].DAV_VENDEDOR)).FirstOrDefault();
                preVendas[i].NomeVendedor = locVendedor == null? preVendas[i].DAV_VENDEDOR: locVendedor.VEN_NOME; 
            }

            stopwatch.Stop();
            lwVendas.ItemsSource = preVendas;
            return;

        }

    }

}
