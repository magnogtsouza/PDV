using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITENSPEDIDOVENDACONFERENCIA")]
public class ITENSPEDIDOVENDACONFERENCIA
{
	[Key]
	[Column(Order = 0)]
	public short IPC_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string IPC_PRODUTO { get; set; }

	public double? IPC_QUANTIDADE { get; set; }

	public DateTime? IPC_ATUALIZACAO { get; set; }
}
