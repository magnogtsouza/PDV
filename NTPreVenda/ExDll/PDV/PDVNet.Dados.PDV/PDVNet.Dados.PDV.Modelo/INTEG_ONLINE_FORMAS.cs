using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_ONLINE_FORMAS
{
	[Key]
	[Column(Order = 0)]
	public byte FOR_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte FOR_CARTAO_PDV { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(50)]
	public string FOR_FORMA_ONLINE { get; set; }

	[Key]
	[Column(Order = 3)]
	[StringLength(18)]
	public string FOR_TIPO_CARTAO { get; set; }
}
