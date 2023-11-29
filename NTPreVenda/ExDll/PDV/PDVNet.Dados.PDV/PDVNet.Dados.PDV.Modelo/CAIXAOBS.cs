using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class CAIXAOBS
{
	[Key]
	[StringLength(20)]
	public string CAO_DOC { get; set; }

	[StringLength(255)]
	public string CAO_OBS { get; set; }
}
