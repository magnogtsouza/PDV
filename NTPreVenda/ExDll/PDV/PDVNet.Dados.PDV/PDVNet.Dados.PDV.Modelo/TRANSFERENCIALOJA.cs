using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class TRANSFERENCIALOJA
{
	public short? TRA_ORIGEM { get; set; }

	public short? TRA_DESTINO { get; set; }

	public DateTime? TRA_CADASTRO { get; set; }

	[StringLength(14)]
	public string TRA_PRODUTO { get; set; }

	public double? TRA_QUANTIDADE { get; set; }

	[StringLength(1)]
	public string TRA_TIPO { get; set; }

	[StringLength(6)]
	public string TRA_CODIGO { get; set; }

	public byte? TRA_BATIMENTO { get; set; }

	[StringLength(1)]
	public string TRA_RAZAO { get; set; }

	public DateTime? TRA_D_BATIMENTO { get; set; }

	public short? TRA_FILIAL_RAZAO { get; set; }

	public double? TRA_QUANTIDADE_BATIMENTO { get; set; }

	public byte? TRA_TRANSITO { get; set; }

	[StringLength(5)]
	public string TRA_SISTEMA { get; set; }

	[StringLength(8)]
	public string TRA_MATRICULA { get; set; }

	public byte? TRA_BATIMENTO2 { get; set; }

	public byte? TRA_TRANSITO2 { get; set; }

	[StringLength(20)]
	public string TRA_REMANEJAMENTO { get; set; }

	public double? TRA_FATOR_CONVERSAO { get; set; }
}
