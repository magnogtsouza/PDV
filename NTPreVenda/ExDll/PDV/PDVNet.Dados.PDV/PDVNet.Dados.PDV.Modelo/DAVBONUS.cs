using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class DAVBONUS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(13)]
	public string DAB_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(9)]
	public string DAB_BONUS { get; set; }
}
