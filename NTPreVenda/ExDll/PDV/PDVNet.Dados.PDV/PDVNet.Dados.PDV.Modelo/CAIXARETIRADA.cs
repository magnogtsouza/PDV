using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAIXARETIRADA")]
public class CAIXARETIRADA
{
	[Key]
	[Column(Order = 0)]
	[StringLength(8)]
	public string CAR_FUNCIONARIO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string CAR_DOC { get; set; }
}
