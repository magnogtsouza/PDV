using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TAREFASTIPO")]
public class TAREFASTIPO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short TAT_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte TAT_TIPO { get; set; }

	public short? TAT_DIAS { get; set; }
}
