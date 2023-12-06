using NTPreVenda.db.Models;
using System.Diagnostics;

namespace NTPreVenda;

public partial class LoadCache : ContentPage
{
    public LoadCache()
    {
        InitializeComponent();
    }

    private async Task Loading()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        Task[] tasks = new Task[]
        {
                 Task.Run(async () =>
            {
                IDictionary<string, string> where = new Dictionary<string, string>();
                where.Add("REF_INATIVO2", "0");
                List<Referencia> refs = await new db.Models.Referencia().GetList(0, where) as List<db.Models.Referencia>;
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
            }),
                Task.Run(async () =>
            {
                IDictionary<string, string> where2 = new Dictionary<string, string>();
                where2.Add("COL_INATIVO2", "0");
                List<Colecao> mat = await new Colecao().GetList(0, where2) as List<Colecao>;
                VarGlobais.Colecoes = mat;
            })
        };

        while (tasks.Any(x => !x.IsCompleted))
        {
            double completos = tasks.Where(x => x.IsCompleted).Count();
            double total = tasks.Count();
            double value = completos / total;
            pbProgress.Progress = (value);
            lblTempoDecorrido.Text = "TEMPO DECORRIDO: " + stopwatch.Elapsed.ToString(@"mm\:ss\:ff");
            await Task.Delay(230);
        }
        pbProgress.Progress = 1;
        stopwatch.Stop();
        lblTempoDecorrido.Text = "TEMPO DECORRIDO: " + stopwatch.Elapsed.ToString(@"mm\:ss\:ff") + " FINALIZADO!";
        await Task.Delay(1000);
    }

    private async void ContentPage_Loaded(object sender, EventArgs e)
    {
        //await DisplayAlert("ok", "ok1", "ok3");
        await Loading();
        await Shell.Current.GoToAsync("//MainPage", true);
    }
}