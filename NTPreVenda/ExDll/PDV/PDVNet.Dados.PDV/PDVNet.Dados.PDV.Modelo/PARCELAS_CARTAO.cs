using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class PARCELAS_CARTAO
{
	[Required]
	public byte? PARC_CODIGO_CARTAO { get; set; }

	public double? PARC_VALOR { get; set; }

	public DateTime? PARC_LIQUIDACAO { get; set; }

	public byte? PARC_PARCELA { get; set; }

	public DateTime? PARC_VENCIMENTO { get; set; }

	public short? PARC_FILIAL { get; set; }

	public int? PARC_EXTRATO { get; set; }

	public byte? PARC_TIPO { get; set; }

	public byte? PARC_PARCELADO { get; set; }

	[StringLength(5)]
	public string PARC_PARCELAS { get; set; }

	[StringLength(20)]
	public string PARC_NUMERO { get; set; }

	public double? PARC_TAXA { get; set; }

	public double? PARC_LIQUIDO { get; set; }

	[StringLength(10)]
	public string PARC_RESUMO { get; set; }

	[Key]
	[Column(Order = 0)]
	public byte PARC_SEQ { get; set; }

	public DateTime? PARC_DATA { get; set; }

	public byte? PARC_TIPO2 { get; set; }

	public byte? PARC_PARCELADO2 { get; set; }

	public byte? PARC_TELA { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string PARC_DOC { get; set; }

	public byte? PARC_STATUS { get; set; }

	public byte? PARC_SISTEMA2 { get; set; }

	public bool? PARC_INATIVA { get; set; }

	[StringLength(12)]
	public string PARC_NSU { get; set; } = "";


	public byte? PARC_SEQ_VENDA { get; set; }

	public bool? PARC_TEF { get; set; }

	public string PARC_AUTORIZACAO { get; set; }

	public bool PARC_RECEBIMENTO_CONSOLIDADO { get; set; }
}
