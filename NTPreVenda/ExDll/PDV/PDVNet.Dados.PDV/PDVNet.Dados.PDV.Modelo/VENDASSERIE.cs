using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("VENDASSERIE")]
public class VENDASSERIE
{
	[Required]
	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string VES_PRODUTO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string VES_SERIE { get; set; }

	public bool? VES_NATUREZA { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(20)]
	public string VES_DOC { get; set; }
}
