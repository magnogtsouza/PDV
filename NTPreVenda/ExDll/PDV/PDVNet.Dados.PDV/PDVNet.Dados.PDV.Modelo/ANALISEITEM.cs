using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ANALISEITEM")]
public class ANALISEITEM
{
	[Key]
	[Column(Order = 0)]
	public int ANI_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short ANI_SEQ { get; set; }

	[StringLength(14)]
	public string ANI_PRODUTO { get; set; }

	public double? ANI_QUANTIDADE { get; set; }

	public double? ANI_VALOR { get; set; }

	public short? ANI_MOTIVO { get; set; }

	public DateTime? ANI_DATA_LIMITE { get; set; }

	public DateTime? ANI_OBSERVACAO { get; set; }

	public short? ANI_STATUS { get; set; }

	public DateTime? ANI_DATAVENDA { get; set; }

	[StringLength(9)]
	public string ANI_NOTAVENDA { get; set; }
}
