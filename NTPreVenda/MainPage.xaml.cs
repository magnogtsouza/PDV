using Microsoft.Data.SqlClient;
using NTPreVenda.Models;

namespace NTPreVenda
{
    public partial class MainPage : ContentPage
    {
        //int count = 0;
        //PreVendaOrc[] vendas;
        public MainPage()
        {
            InitializeComponent();
            db.Models.PreVenda s = new db.Models.PreVenda();
            //vendas = new PreVendaOrc[3];
            //vendas[0] = new PreVendaOrc { Id = 0001, Valor = 900, Vendedor = "janmes" , Cliente = "Roberto"};
            //vendas[1] = new PreVendaOrc { Id = 0005, Valor = 102.50, Vendedor = "Ruliam" ,Cliente = "Magno" };
            //vendas[2] = new PreVendaOrc { Id = 0023, Valor = 25.50, Vendedor = "Francis", Cliente = "Luzinet" };
            //lwVendas.ItemsSource = vendas;
            //Shell.Current.GoToAsync("//Login");
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
            Task<SqlConnection> cnnT = Task.Run(() => db.Pool.GetConnection());
            string selec = new db.Models.PreVenda().SelectString();
            SqlConnection cnn = await cnnT;
            SqlCommand cmd = new SqlCommand(selec, cnn);
            SqlDataReader reader = await cmd.ExecuteReaderAsync();

            List<db.Models.PreVenda> preVendas = new List<db.Models.PreVenda>();
            while (reader.Read())
            {
                /*
                preVendas.Add(new db.Models.PreVenda()
                {
                    DAV_DOC = reader.GetString(0),
                    DAV_TIPO = reader.GetByte(1),
                    DAV_FILIAL = reader.GetInt32(2),
                    DAV_CAIXA = reader.GetString(3),
                    DAV_VALOR = reader.GetDouble(4),
                    DAV_DOC_CAIXA = reader.GetString(5),
                    DAV_STATUS = reader.GetByte(6),
                    DAV_NOME = reader.GetString(7),
                    DAV_DATA = reader.GetDateTime(8),
                    DAV_TABELA = reader.GetByte(9),
                    DAV_VENDEDOR = reader.GetString(10),
                    DAV_CODIGON = reader.GetString(11),
                    DAV_CONDICAO = reader.GetInt16(12),
                    DAV_TIPO_DESCONTO = reader.GetByte(13),
                    DAV_DESCONTO = reader.GetDouble(14),
                    DAV_MATRICULA_AUTORIZA = reader.GetString(15),
                    DAV_OBSERVACAO = reader.GetString(16),
                    DAV_BONUS = reader.GetDouble(17),
                    DAV_CONFERIDO = reader.GetBoolean(18),
                    DAV_MATRICULA = reader.GetString(19),
                    DAV_PARCELAS = reader.GetInt16(20)
                });
                */
                var novo = new db.Models.PreVenda();
                novo.DAV_DOC = reader.GetString(0);
                novo.DAV_TIPO = reader.GetByte(1);
                novo.DAV_FILIAL = reader.GetInt16(2);
                novo.DAV_CAIXA = reader.GetByte(3);
                novo.DAV_VALOR = reader.GetDouble(4);
                novo.DAV_DOC_CAIXA = reader.GetString(5);
                novo.DAV_STATUS = reader.GetByte(6);
                novo.DAV_NOME = reader.GetString(7);
                novo.DAV_DATA = reader.GetDateTime(8);
                novo.DAV_TABELA = reader.GetByte(9);
                novo.DAV_VENDEDOR = reader.GetString(10);
                novo.DAV_CODIGON = reader.GetString(11);
                novo.DAV_CONDICAO = reader.GetInt16(12);
                novo.DAV_TIPO_DESCONTO = reader.GetByte(13);
                novo.DAV_DESCONTO = reader.GetDouble(14);
                novo.DAV_MATRICULA_AUTORIZA = reader.GetString(15);
                novo.DAV_OBSERVACAO = reader.GetString(16);
                novo.DAV_BONUS = reader.GetDouble(17);
                novo.DAV_CONFERIDO = reader.GetBoolean(18);
                novo.DAV_MATRICULA = reader.GetString(19);
                novo.DAV_PARCELAS = reader.GetInt16(20);
                preVendas.Add(novo);
            }
            return;

        }

    }

}
