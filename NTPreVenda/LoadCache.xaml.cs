using System.Diagnostics;

namespace NTPreVenda;

public partial class LoadCache : ContentPage
{
    public LoadCache()
    {
        InitializeComponent();
        Loading();
    }

    private async void Loading()
    {
        Stopwatch time = Stopwatch.StartNew();
        string listInString = await new db.Models.Vendedor().ToListExpando();
        List<db.Models.Vendedor> vendedors = await new db.Models.Vendedor().GetList() as List<db.Models.Vendedor>;
        VarGlobais.Vendedores = vendedors.ToArray();
        time.Stop();
        Shell.Current.GoToAsync("//MainPage");
    }


}