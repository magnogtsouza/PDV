using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ESTADOICMS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(2)]
	public string ESI_ORIGEM { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(2)]
	public string ESI_DESTINO { get; set; }

	public double? ESI_ICMS { get; set; }
}
