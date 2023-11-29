using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("GRUPOCONTA")]
public class GRUPOCONTA
{
	[Key]
	[StringLength(2)]
	public string GRU_CODIGO { get; set; }

	[StringLength(30)]
	public string GRU_DESCRICAO { get; set; }
}
