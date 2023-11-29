using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("VENDASKIT")]
public class VENDASKIT
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string VEK_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short VEK_ITEM { get; set; }

	[StringLength(8)]
	public string VEK_KIT { get; set; }

	public short? VEK_ITEM_PRINCIPAL { get; set; }
}
