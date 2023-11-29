using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAIXAFORMA")]
public class CAIXAFORMA
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string CAF_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte CAF_SEQ { get; set; }

	public byte? CAF_FORMA { get; set; }

	public short? CAF_PLANO_PAGAMENTO { get; set; }

	public double? CAF_VALOR { get; set; }
}
