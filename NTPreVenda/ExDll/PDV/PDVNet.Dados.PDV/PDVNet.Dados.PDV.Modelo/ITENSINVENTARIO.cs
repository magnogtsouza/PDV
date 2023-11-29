using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITENSINVENTARIO")]
public class ITENSINVENTARIO
{
	[Key]
	[Column(Order = 0)]
	public short ITV_INVENTARIO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short ITV_LOTE { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(14)]
	public string ITV_PRODUTO { get; set; }

	public double? ITV_QUANTIDADE { get; set; }

	[Key]
	[Column(Order = 3)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short? ITV_FILIAL { get; set; }
}
