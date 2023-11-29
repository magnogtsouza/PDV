using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("PEDIDOVENDACONFERENCIA")]
public class PEDIDOVENDACONFERENCIA
{
	[Key]
	[Column(Order = 0)]
	public short PVC_CODIGO { get; set; }

	[StringLength(6)]
	public string PVC_PEDIDO { get; set; }

	[StringLength(16)]
	public string PVC_CODIGON { get; set; }

	[StringLength(20)]
	public string PVC_NOTA_FISCAL_DOC { get; set; }

	[StringLength(8)]
	public string PVC_MATRICULA { get; set; }

	public DateTime? PVC_ATUALIZACAO { get; set; }

	public byte PVC_STATUS { get; set; }
}
