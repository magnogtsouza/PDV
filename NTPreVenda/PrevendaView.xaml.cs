using NTPreVenda.db.Models;

namespace NTPreVenda;

public partial class PrevendaView : ContentPage
{
    public Vendedor vendedor { get; private set; }
    public PreVenda preVenda { get; private set; }
    public List<ItemPrevenda> items { get; private set; }
    public PrevendaView(Vendedor vendedor, PreVenda preVenda = null)
    {
        this.vendedor = vendedor;
        this.preVenda = preVenda;
        InitializeComponent();
        InitializePrevenda();
    }

    private async void InitializePrevenda()
    {
        if (vendedor == null)
        {
            await DisplayAlert("Selecione um vendedor antes", "Nenhum vendedor foi selecionado", "OK");
            await Shell.Current.Navigation.PopAsync();
            return;
        }
        lblVendedor.Text = vendedor.ToString();
        if (preVenda != null)
        {
            entryClientName.Text = preVenda.DAV_NOME;
            EntryObservacaoNota.Text = preVenda.DAV_OBSERVACAO;
            if (!preVenda.DAV_VENDEDOR.Equals(vendedor.VEN_CODIGO))
            {
                await DisplayAlert("Esta prevenda não é sua", $"O vendedor selecionado é o {vendedor.VEN_APELIDO}, e o vendedor que criou esta venda foi o {preVenda.NomeVendedor}", "OK");
                await Shell.Current.Navigation.PopAsync();
                return;
            }
            IDictionary<string, string> clauures = new Dictionary<string, string>();
            clauures.Add("DAI_INATIVO", "0");
            clauures.Add("DAI_DOC", preVenda.DAV_DOC);
            items = await new ItemPrevenda().GetList(0, clauures) as List<ItemPrevenda>;
            lblTotal.Text = preVenda.DAV_VALOR.ToString();
        }
        else
        {
            preVenda = new PreVenda()
            {
                DAV_VENDEDOR = vendedor.VEN_CODIGO,
                DAV_FILIAL = VarGlobais.FilialCodigo,
                DAV_TIPO = 1,
                DAV_CAIXA = 255,
                DAV_VALOR = 0,
                DAV_DOC_CAIXA = string.Empty,
                DAV_STATUS = 1,
                DAV_NOME = null,
                DAV_OBSERVACAO = null,
                DAV_DATA = DateTime.Now,
                DAV_TABELA = 3,
                DAV_CODIGON = null,
                DAV_CONDICAO = 0,
                DAV_TIPO_DESCONTO = 0,
                DAV_MATRICULA_AUTORIZA = null,
                DAV_ATUALIZACAO = DateTime.Now,
                DAV_BONUS = 0,
                DAV_CONFERIDO = false,
                DAV_MATRICULA = null,
                DAV_PARCELAS = 0,
                NaoSalvo = true
            };
        }
        if (VarGlobais.Referencias == null || VarGlobais.Referencias.Count == 0)
        {
            VarGlobais.Referencias = await new Referencia().GetList(0) as List<Referencia>;
        }

        for (int i = 0; i < items.Count; i++)
        {
            Referencia referencia = VarGlobais.Referencias.Where(x => x.MATERIAIS.Any(x=>x.MAT_CODIGO.Equals(items[i].DAI_PRODUTO))).FirstOrDefault();
            if (referencia != null)
            {
                items[i].Referencia = referencia;
            }
        }
        lwItens.ItemsSource = items;
    }

}