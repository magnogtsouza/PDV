using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("OPERADORACARTAOCONCILIACAO")]
public class OPERADORACARTAOCONCILIACAO
{
	[Key]
	[Column(Order = 0)]
	public int OCO_CODIGO { get; set; }

	public byte? OCO_OPERADORA { get; set; }

	public short? OCO_FILIAL { get; set; }

	public byte? OCO_ARQUIVO_TIPO_EXTRATO { get; set; }

	[StringLength(10)]
	public string OCO_ESTABELECIMENTO { get; set; }

	[StringLength(40)]
	public string OCO_NUMERO_LOGICO { get; set; }

	public short? OCO_TIPO_EVENTO { get; set; }

	public short? OCO_TIPO_TRANSACAO { get; set; }

	public short? OCO_CANAL_ENTRADA { get; set; }

	public short? OCO_MEIO_CAPTURA { get; set; }

	public short? OCO_FORMA_PAGAMENTO { get; set; }

	public short? OCO_STATUS_PAGAMENTO { get; set; }

	public short? OCO_REGIME_RECEBIMENTO { get; set; }

	public short? OCO_REGIME_DIAS { get; set; }

	[StringLength(12)]
	public string OCO_NSU { get; set; }

	[StringLength(6)]
	public string OCO_NUMERO_CARTAO_INICIO { get; set; }

	[StringLength(4)]
	public string OCO_NUMERO_CARTAO_FIM { get; set; }

	[StringLength(6)]
	public string OCO_CODIGO_AUTORIZACAO { get; set; }

	[StringLength(50)]
	public string OCO_CODIGO_TRANSACAO { get; set; }

	public DateTime? OCO_DATA_VENDA { get; set; }

	public DateTime? OCO_DATA_TRANSACAO { get; set; }

	public DateTime? OCO_DATA_PREVISTA_PAGAMENTO { get; set; }

	public DateTime? OCO_DATA_PAGAMENTO { get; set; }

	public short? OCO_PARCELA { get; set; }

	public short? OCO_TOTAL_PARCELAS { get; set; }

	public double? OCO_VALOR_ORIGINAL_TRANSACAO { get; set; }

	public double? OCO_VALOR_TOTAL_TRANSACAO { get; set; }

	public double? OCO_VALOR_PARCELA { get; set; }

	public double? OCO_TAXA { get; set; }

	public double? OCO_VALOR_LIQUIDO { get; set; }

	public double? OCO_TAXA_ANTECIPACAO { get; set; }

	public double? OCO_VALOR_LIQUIDO_ANTECIPACAO { get; set; }

	[StringLength(30)]
	public string OCO_BANDEIRA { get; set; }

	[StringLength(50)]
	public string OCO_CV { get; set; }

	public bool OCO_CONCILIADO { get; set; }

	public DateTime OCO_ATUALIZACAO { get; set; }

	public double? OCO_VALOR_PARCELA_LIQUIDO { get; set; }

	public double? OCO_TAXA_PARCELA { get; set; }

	public byte OCO_TIPO_PARCELAMENTO { get; set; }

	public string OCO_DOC { get; set; }

	public string OCO_SEQ_PARCELA { get; set; }

	[NotMapped]
	public double TaxaPercentual { get; set; }

	[NotMapped]
	public double ValorProximaParcela { get; set; }
}
