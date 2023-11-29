using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CHEQUESPAGAMENTOS
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int REL_CHEQUE { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(6)]
	public string REL_PAGAMENTO { get; set; }
}
