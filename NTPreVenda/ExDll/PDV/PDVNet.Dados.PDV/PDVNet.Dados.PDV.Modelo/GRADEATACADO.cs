using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("GRADEATACADO")]
public class GRADEATACADO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(2)]
	public string GRA_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string GRA_PRODUTO { get; set; }

	public double? GRA_QTD { get; set; }
}
