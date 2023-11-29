using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("GRADE")]
public class GRADE
{
	[Key]
	[StringLength(2)]
	public string GRA_CODIGO { get; set; }

	[StringLength(20)]
	public string GRA_DESCRICAO { get; set; }
}
