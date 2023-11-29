using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FORMASPAGAMENTO")]
public class FORMASPAGAMENTO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(2)]
	public string FOR_IMPRESSORA { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(1)]
	public string FOR_FORMA { get; set; }

	[StringLength(30)]
	public string FOR_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte FOR_CAIXA { get; set; }
}
