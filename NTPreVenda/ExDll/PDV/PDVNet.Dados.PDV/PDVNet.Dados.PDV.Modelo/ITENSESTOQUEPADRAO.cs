using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITENSESTOQUEPADRAO")]
public class ITENSESTOQUEPADRAO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(8)]
	public string IEP_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int IEP_FILIAL { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(14)]
	public string IEP_PRODUTO { get; set; }

	public double? IEP_QUANTIDADE { get; set; }
}
