using NTPreVenda.db.Models;
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

        Task[] tasks = new Task[]
        {
                 Task.Run(async () =>
            {
                IDictionary<string, string> where = new Dictionary<string, string>();
                where.Add("REF_INATIVO2", "0");
                List<db.Models.Referencia> refs = await new db.Models.Referencia().GetList(0, where) as List<db.Models.Referencia>;
                VarGlobais.Referencias = refs;
            }),
                 Task.Run(async () =>
            {
                IDictionary<string, string> clausures = new Dictionary<string, string>();
                clausures.Add("VEN_FILIAL", "9");
                clausures.Add("VEN_INATIVO", "0");
                List<db.Models.Vendedor> vendedors = await new db.Models.Vendedor().GetList(0, clausures) as List<db.Models.Vendedor>;
                VarGlobais.Vendedores = vendedors.ToArray();
            }),
                  Task.Run(async () =>
            {
                IDictionary<string, string> where2 = new Dictionary<string, string>();
                where2.Add("MAT_INATIVO", "0");
                List<MATERIAIS> mat = await new MATERIAIS().GetList(0, where2) as List<MATERIAIS>;
                VarGlobais.Materiais = mat;
            })
        };
        /*
        Task updateReferencias = Task.Run(async () =>
        {
            IDictionary<string, string> where = new Dictionary<string, string>();
            where.Add("REF_INATIVO2", "0");
            List<db.Models.Referencia> refs = await new db.Models.Referencia().GetList(0, where) as List<db.Models.Referencia>;
            VarGlobais.Referencias = refs;
        });


        Task updateVendedores = Task.Run(async () =>
        {
            IDictionary<string, string> clausures = new Dictionary<string, string>();
            clausures.Add("VEN_FILIAL", "9");
            clausures.Add("VEN_INATIVO", "0");
            List<db.Models.Vendedor> vendedors = await new db.Models.Vendedor().GetList(0, clausures) as List<db.Models.Vendedor>;
            VarGlobais.Vendedores = vendedors.ToArray();
        });

        Task updateMAterials = Task.Run(async () =>
        {
            IDictionary<string, string> where2 = new Dictionary<string, string>();
            where2.Add("MAT_INATIVO", "0");
            List<MATERIAIS> mat = await new MATERIAIS().GetList(0, where2) as List<MATERIAIS>;
            VarGlobais.Materiais = mat;
        });
        */

        while (tasks.Any(x => !x.IsCompleted))
        {
            //await Task.Delay(1000);
        }
        time.Stop();

        while (Shell.Current.IsBusy)
        {

        }

        await Shell.Current.GoToAsync("//MainPage", true);
        //Shell.Current.Navigation.PushAsync(new MainPage(), true);
    }


}