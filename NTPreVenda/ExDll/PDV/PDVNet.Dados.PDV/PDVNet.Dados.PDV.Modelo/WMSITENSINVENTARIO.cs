using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("WMSITENSINVENTARIO")]
public class WMSITENSINVENTARIO
{
	[Key]
	[Column(Order = 0)]
	public short WII_INVENTARIO { get; set; }

	[Key]
	[Column(Order = 1)]
	public int WII_CAIXA { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(14)]
	public string WII_PRODUTO { get; set; }

	public double? WII_QUANTIDADE { get; set; }
}
