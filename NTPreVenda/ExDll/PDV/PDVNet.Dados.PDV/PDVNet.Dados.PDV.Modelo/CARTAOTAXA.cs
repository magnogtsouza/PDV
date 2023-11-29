using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CARTAOTAXA")]
public class CARTAOTAXA
{
	[Key]
	[Column(Order = 0)]
	public byte? CTX_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short? CTX_FILIAL { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte? CTX_PARCELA { get; set; }

	public double? CTX_TAXA { get; set; }
}
