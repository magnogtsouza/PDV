using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALMETADIA")]
public class FILIALMETADIA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int FIM_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte FIM_DIA { get; set; }

	public double? FIM_PERCENTUAL { get; set; }
}
