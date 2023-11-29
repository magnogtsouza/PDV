using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ENDERECOREFERENCIA")]
public class ENDERECOREFERENCIA
{
	[Key]
	[Column(Order = 0)]
	public byte ENR_TIPO_CADASTRO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(16)]
	public string ENR_CODIGO { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte ENR_SEQ { get; set; }

	[StringLength(70)]
	public string ENR_REFERENCIA { get; set; }
}
