using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ESTOQUESERIE")]
public class ESTOQUESERIE
{
	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string EST_PRODUTO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string EST_SERIE { get; set; }

	public double? EST_ESTOQUE { get; set; }
}
