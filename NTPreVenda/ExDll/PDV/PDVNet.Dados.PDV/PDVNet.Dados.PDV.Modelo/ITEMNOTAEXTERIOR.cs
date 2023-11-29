using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITEMNOTAEXTERIOR")]
public class ITEMNOTAEXTERIOR
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string INE_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public short INE_SEQ { get; set; }

	public double? INE_BC_IMPORTACAO { get; set; }

	public double? INE_VALOR_ADUANEIRAS { get; set; }

	public double? INE_VALOR_IMPORTACAO { get; set; }

	public double? INE_VALOR_IOF { get; set; }
}
