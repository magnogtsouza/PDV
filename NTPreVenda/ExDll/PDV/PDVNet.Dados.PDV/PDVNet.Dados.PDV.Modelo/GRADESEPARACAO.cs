using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("GRADESEPARACAO")]
public class GRADESEPARACAO
{
	[Key]
	public int GRA_CODIGO { get; set; }

	[StringLength(14)]
	public string GRA_PRODUTO { get; set; }

	public short? GRA_FILIAL { get; set; }

	public double? GRA_QUANTIDADE { get; set; }

	public byte? GRA_PROCESSADO { get; set; }

	public DateTime? GRA_DATA { get; set; }

	public byte? GRA_PROCESSADO2 { get; set; }

	public short? GRA_FILIAL_SAIDA { get; set; }

	public double? GRA_FATOR_CONVERSAO { get; set; }
}
