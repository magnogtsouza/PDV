using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONSERTOITEM")]
public class CONSERTOITEM
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string COI_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public short COI_SEQ { get; set; }

	[StringLength(14)]
	public string COI_PRODUTO { get; set; }

	public double? COI_QUANTIDADE { get; set; }

	public double? COI_VALOR { get; set; }

	public short? COI_MOTIVO { get; set; }

	public string COI_OBSERVACAO { get; set; }

	public byte? COI_STATUS { get; set; }

	public DateTime? COI_ATUALIZACAO { get; set; }
}
