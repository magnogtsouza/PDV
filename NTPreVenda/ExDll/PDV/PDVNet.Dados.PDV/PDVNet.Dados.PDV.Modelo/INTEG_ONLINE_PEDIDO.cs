using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_ONLINE_PEDIDO
{
	[Key]
	[Column(Order = 0)]
	public byte PED_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(6)]
	public string PED_CODIGO { get; set; }

	[StringLength(2)]
	public string PED_DV { get; set; }

	[StringLength(20)]
	public string PED_DOC_PDV { get; set; }

	[StringLength(16)]
	public string PED_CODIGON { get; set; }

	[StringLength(30)]
	public string PED_ARQUIVO { get; set; }
}
