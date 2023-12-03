using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTPreVenda.db.Models
{
    internal class Filial: DatabaseItem
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FIL_CODIGO { get; set; }

        [StringLength(50)]
        public string FIL_RAZAO_SOCIAL { get; set; }

        [StringLength(15)]
        public string FIL_INSCRICAO { get; set; }

        [StringLength(18)]
        public string FIL_CGC { get; set; }

        [StringLength(1)]
        public string FIL_ATIVA { get; set; }

        [StringLength(40)]
        public string FIL_EMAIL { get; set; }

        public double? FIL_MARGEM { get; set; }

        public byte? FIL_EMPRESA { get; set; }

        [StringLength(6)]
        public string FIL_PREFIXO { get; set; }

        [StringLength(15)]
        public string FIL_TELEFONE { get; set; }

        [Column(TypeName = "ntext")]
        public string FIL_OBS { get; set; }

        public bool? FIL_DOMINGO { get; set; }

        public bool? FIL_SABADO { get; set; }

        [StringLength(100)]
        public string FIL_RAZAO { get; set; }

        public byte? FIL_GRUPO { get; set; }

        public bool? FIL_FRANQUIA { get; set; }

        public short? FIL_CODIGO_FRANQUIA { get; set; }

        public DateTime? FIL_VERSAO { get; set; }

        public bool? FIL_EXPORTAR { get; set; }

        public bool? FIL_FERIADO { get; set; }

        public bool? FIL_DISTRIBUICAO { get; set; }

        public bool? FIL_INATIVA { get; set; }

        [StringLength(30)]
        public string FIL_CONTATO { get; set; }

        [StringLength(10)]
        public string FIL_FAX { get; set; }

        [StringLength(4)]
        public string FIL_CCUSTO { get; set; }

        public bool? FIL_DIVERSOS { get; set; }

        public bool? FIL_CLIENTES { get; set; }

        public bool? FIL_SALDOS { get; set; }

        public bool? FIL_PROCESSA { get; set; }

        public byte? FIL_TIPO2 { get; set; }

        public bool? FIL_DIVERGENCIA { get; set; }

        public bool? FIL_TRANSFERENCIA { get; set; }

        [StringLength(16)]
        public string FIL_CODIGON { get; set; }

        public bool? FIL_FATURAMENTO { get; set; }

        public bool? FIL_ESTOQUE_FATURAMENTO { get; set; }

        public bool? FIL_RECEBE_PROMOCAO { get; set; }

        public bool? FIL_PAULISTA { get; set; }

        [StringLength(6)]
        public string FIL_FORNECEDOR { get; set; }

        public bool? FIL_ESTOQUE { get; set; }

        public byte? FIL_DIS_CUSTO { get; set; }

        public byte? FIL_DIS_VENDA { get; set; }

        public byte? FIL_PRECO_ETIQUETA { get; set; }

        public bool? FIL_CUPOM_MANIA { get; set; }

        public byte? FIL_DIS_EXIBIR { get; set; }

        public byte? FIL_QUANTIDADE_PRE { get; set; }

        public byte? FIL_COMISSAO_RETIRADA { get; set; }

        public byte? FIL_TRIBUTACAO { get; set; }

        public bool? FIL_RECEBE_PEDIDO { get; set; }

        public bool? FIL_ESTOQUE_NEGATIVO { get; set; }

        public bool? FIL_ARMAZENA_TENTATIVA_NEGATIVO { get; set; }

        public short? FIL_FILIAL_FATURAMENTO { get; set; }

        [StringLength(15)]
        public string FIL_INSCRICAO_MUNICIPAL { get; set; }

        [StringLength(15)]
        public string FIL_INSCRICAO_EST_S { get; set; }

        public short? FIL_CONTADOR { get; set; }

        public int? FIL_ASSINA { get; set; }

        public byte? FIL_2COMISSIONADO { get; set; }

        [StringLength(16)]
        public string FIL_CHAVE { get; set; }

        public byte? FIL_TIPO_CADASTRO { get; set; }

        public byte? FIL_ENDERECO_PADRAO { get; set; }

        public DateTime? FIL_ATUALIZACAO { get; set; }

        public bool? FIL_DISTRIBUICAO_ESTOQUE { get; set; }

        public bool? FIL_SINCRONISMO { get; set; }

        public bool? FIL_TURNO { get; set; }

        public bool? FIL_MOVIMENTO { get; set; }

        public bool? FIL_NFE_NA_LOJA { get; set; }

        public bool? FIL_PREFATURA { get; set; }

        public bool? FIL_GRADESEPARACAO { get; set; }

        public bool? FIL_DADOS_CLIENTE { get; set; }

        [StringLength(8)]
        public string FIL_MATRICULA { get; set; }

        public short? FIL_CODIGO_REDIRECIONAMENTO { get; set; }

        public double? FIL_METRO_QUADRADO { get; set; }

        public short? FIL_ORDEM { get; set; }

        public bool? FIL_LEI_DA_MODA { get; set; }

        public byte? FIL_SUPERVISOR { get; set; }

        [StringLength(50)]
        public string FIL_CHAVEACESSOVALIDADOR { get; set; }

        public bool? FIL_ONLINE { get; set; }

        public short? FIL_PEDIDO_ENTREGA { get; set; }

        public short? FIL_TIPO_LOJA { get; set; }

        [StringLength(4)]
        public string FIL_CODIGO_RECEITA_SPED { get; set; }

        public bool? FIL_WMS { get; set; }

        public bool? FIL_DOWNLOAD_MATRIZ { get; set; }


        public override Task<object> GetList(uint limint = 1000, IDictionary<string, string> where = null)
        {
            throw new NotImplementedException();
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }
    }
}
