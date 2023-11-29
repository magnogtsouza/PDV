using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("GRUPOLOJA")]
public class GRUPOLOJA
{
	[Key]
	[StringLength(2)]
	public string GRU_CODIGO { get; set; }

	[StringLength(30)]
	public string GRU_DESCRICAO { get; set; }

	public bool? GRU_INATIVO { get; set; }
}
