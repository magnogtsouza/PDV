using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MOTIVOLOJA")]
public class MOTIVOLOJA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int MOT_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public DateTime MOT_DATA { get; set; }

	public byte? MOT_MOTIVO { get; set; }

	public DateTime? MOT_CADASTRO { get; set; }

	[StringLength(50)]
	public string MOT_OBS { get; set; }

	[StringLength(8)]
	public string MOT_MATRICULA { get; set; }
}
