using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CLIENTESOBS
{
	[Key]
	[StringLength(16)]
	public string CLO_CODIGON { get; set; }

	[Column(TypeName = "ntext")]
	public string CLO_OBS { get; set; }
}
