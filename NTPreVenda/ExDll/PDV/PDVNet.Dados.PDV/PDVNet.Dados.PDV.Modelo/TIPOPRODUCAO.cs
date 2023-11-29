using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TIPOPRODUCAO")]
public class TIPOPRODUCAO
{
	[Key]
	public byte TIP_CODIGO { get; set; }

	[StringLength(30)]
	public string TIP_DESCRICAO { get; set; }

	[StringLength(5)]
	public string TIP_SINTEGRA { get; set; }
}
