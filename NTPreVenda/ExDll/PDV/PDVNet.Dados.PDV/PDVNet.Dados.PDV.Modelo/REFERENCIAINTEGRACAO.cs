using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class REFERENCIAINTEGRACAO
{
	[Key]
	[Column(Order = 0)]
	public short REI_COLECAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(12)]
	public string REI_REFERENCIA { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte REI_REDE { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte REI_INTEGRACAO { get; set; }
}
