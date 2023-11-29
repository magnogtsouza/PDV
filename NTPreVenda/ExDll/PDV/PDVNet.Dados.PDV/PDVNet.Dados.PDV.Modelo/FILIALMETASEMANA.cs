using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALMETASEMANA")]
public class FILIALMETASEMANA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int FIS_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte FIS_MES { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte FIS_SEMANA { get; set; }

	public double? FIS_PERCENTUAL { get; set; }
}
