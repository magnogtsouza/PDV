using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class PARCELAS
{
	public DateTime? PAR_VENCIMENTO { get; set; }

	public short? PAR_FILIAL { get; set; }

	public double? PAR_VALOR { get; set; }

	public short? PAR_BANCO { get; set; }

	[StringLength(6)]
	public string PAR_CHEQUE { get; set; }

	public DateTime? PAR_LIQUIDACAO { get; set; }

	[StringLength(1)]
	public string PAR_DEVOLVIDO { get; set; }

	public int? PAR_EXTRATO { get; set; }

	[StringLength(4)]
	public string PAR_AGENCIA { get; set; }

	[StringLength(10)]
	public string PAR_CONTA { get; set; }

	[StringLength(3)]
	public string PAR_CUSTODIA { get; set; }

	public byte? PAR_AVISTA { get; set; }

	public int? PAR_BORDERO { get; set; }

	[Key]
	[Column(Order = 0)]
	[StringLength(5)]
	public string PAR_PARCELA { get; set; }

	public DateTime? PAR_DEVOLUCAO { get; set; }

	public DateTime? PAR_DATA { get; set; }

	public byte? PAR_AVISTA2 { get; set; }

	public byte? PAR_TELA { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string PAR_DOC { get; set; }

	public byte? PAR_STATUS { get; set; }

	public byte? PAR_SISTEMA2 { get; set; }

	public bool? PAR_INATIVA { get; set; }
}
