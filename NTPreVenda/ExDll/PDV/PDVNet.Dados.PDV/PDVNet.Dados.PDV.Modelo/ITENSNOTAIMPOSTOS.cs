using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ITENSNOTAIMPOSTOS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string ITI_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public short ITI_ITEM { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte ITI_TIPO { get; set; }

	[StringLength(3)]
	public string ITI_CST { get; set; }

	public float? ITI_BASECALCULO { get; set; }

	public float? ITI_ALIQUOTA { get; set; }

	public float? ITI_VALOR { get; set; }
}
