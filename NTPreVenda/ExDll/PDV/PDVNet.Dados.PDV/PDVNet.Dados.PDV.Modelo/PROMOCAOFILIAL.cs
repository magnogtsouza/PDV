using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("PROMOCAOFILIAL")]
public class PROMOCAOFILIAL
{
	[Key]
	[Column(Order = 0)]
	public short PRF_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short PRF_FILIAL { get; set; }
}
