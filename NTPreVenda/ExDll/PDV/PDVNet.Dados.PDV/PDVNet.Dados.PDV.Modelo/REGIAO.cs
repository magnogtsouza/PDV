using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REGIAO")]
public class REGIAO
{
	[Key]
	public byte REG_CODIGO { get; set; }

	[StringLength(20)]
	public string REG_DESCRICAO { get; set; }
}
