using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("BORDEROPAGAMENTO")]
public class BORDEROPAGAMENTO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int BPG_BORDERO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(6)]
	public string BPG_PAGAMENTO { get; set; }
}
