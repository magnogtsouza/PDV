using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MATERIAISCOR")]
public class MATERIAISCOR
{
	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string MAC_PRODUTO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int MAC_COR { get; set; }

	public bool? MAC_INATIVO { get; set; }

	public DateTime? MAC_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string MAC_MATRICULA { get; set; }
}
