using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("GERENCIAL")]
public class GERENCIAL
{
	[Key]
	[StringLength(2)]
	public string GER_CODIGO { get; set; }

	[StringLength(30)]
	public string GER_DESCRICAO { get; set; }
}
