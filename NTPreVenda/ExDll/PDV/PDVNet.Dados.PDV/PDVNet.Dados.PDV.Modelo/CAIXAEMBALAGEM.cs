using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAIXAEMBALAGEM")]
public class CAIXAEMBALAGEM
{
	[Key]
	[Column(Order = 0)]
	[StringLength(3)]
	public string CAE_EMBALAGEM { get; set; }

	public byte? CAE_QUANTIDADE { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string CAE_DOC { get; set; }
}
