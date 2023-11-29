using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class KITPRECO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(8)]
	public string KIP_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short KIP_TABELA { get; set; }

	public double? KIP_PRECO { get; set; }

	public double? KIP_DESCONTO { get; set; }
}
