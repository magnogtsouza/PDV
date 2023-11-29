using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("RECEBER")]
public class RECEBER
{
	[Key]
	[StringLength(6)]
	public string REC_CODIGO { get; set; }

	public short? REC_FILIAL { get; set; }

	[StringLength(4)]
	public string REC_CENTRO { get; set; }

	public short REC_CLASSIFICACAO { get; set; }

	[StringLength(1)]
	public string REC_TIPO { get; set; }

	[StringLength(50)]
	public string REC_OBS { get; set; }

	[StringLength(1)]
	public string REC_STATUS { get; set; }

	[StringLength(5)]
	public string REC_PARCELAS { get; set; }

	[StringLength(8)]
	public string REC_MATRICULA { get; set; }

	public int? REC_EXTRATO { get; set; }

	public DateTime? REC_CADASTRO { get; set; }

	public DateTime? REC_EMISSAO { get; set; }

	public DateTime? REC_VENCIMENTO { get; set; }

	public DateTime? REC_BAIXA { get; set; }

	public DateTime? REC_ALTERACAO { get; set; }

	public DateTime? REC_CANCELAMENTO { get; set; }

	public double? REC_VALOR { get; set; }

	public double? REC_DESCONTO { get; set; }

	public double? REC_ACRESCIMO { get; set; }

	public double? REC_VALOR_PAGO { get; set; }

	[StringLength(6)]
	public string REC_FORNECEDOR { get; set; }

	public int? REC_CLIENTE { get; set; }

	public DateTime? REC_FLUXO { get; set; }

	[StringLength(6)]
	public string REC_CHEQUE { get; set; }

	[StringLength(2)]
	public string REC_MOEDA { get; set; }

	[StringLength(1)]
	public string REC_TIPO_DEVEDOR { get; set; }

	public DateTime? REC_VENCIMENTO_BAIXA { get; set; }

	public DateTime? REC_COMPETENCIA { get; set; }

	[StringLength(16)]
	public string REC_CODIGON { get; set; }

	[StringLength(20)]
	public string REC_DOCUMENTO { get; set; }
}
