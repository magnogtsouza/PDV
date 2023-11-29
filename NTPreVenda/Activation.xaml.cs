using System.Diagnostics;
using Microsoft.Data.SqlClient;
namespace NTPreVenda;

public partial class Activation : ContentPage
{
    public Activation()
    {
        InitializeComponent();
        GetInfo();
    }
    private async Task GetInfo()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        var fingerprint = await Task.Run(() => VarGlobais.DeviceInfo);
        lblFingerprint.Text = fingerprint.Fingerprint;
        lblMaisInfo.Text = fingerprint.Name + '\n' + fingerprint.Description;
        entryDescription.Text = fingerprint.Description;
        stopwatch.Stop();

        SqlConnection cnn = await Task.Run(() => db.Pool.GetConnection());
        db.Models.ItemPrevenda t = new db.Models.ItemPrevenda();
        string sle = t.SelectString();
        if (cnn == null)
        {
            DisplayAlert("Error", "Não foi possivel conectar ao banco de dados", "OK");
        }
        db.Pool.CloseConnecton(cnn);
        return;
    }

    private async void ButtonUpdate_Clicked(object sender, EventArgs e)
    {
        string newDesc = entryDescription.Text;
        VarGlobais.Data.SaveCfg("Description", newDesc);
        VarGlobais.RefreshInfo();
        await GetInfo();


    }
}