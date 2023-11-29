using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ITENSNOTAIMPOSTOSICMS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string III_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public short III_ITEM { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte III_TIPO { get; set; }

	[StringLength(3)]
	public string III_CST { get; set; }

	public byte? III_MODALIDADE_BC { get; set; }

	public float? III_REDUCAO_BC { get; set; }

	public float? III_CREDITOVALOR { get; set; }

	public float? III_MVA { get; set; }
}
