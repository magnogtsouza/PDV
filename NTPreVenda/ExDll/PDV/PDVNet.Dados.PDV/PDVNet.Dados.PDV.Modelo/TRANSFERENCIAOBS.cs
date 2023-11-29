using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class TRANSFERENCIAOBS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(6)]
	public string TRO_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int TRO_ORIGEM { get; set; }

	[StringLength(100)]
	public string TRO_OBS { get; set; }
}
