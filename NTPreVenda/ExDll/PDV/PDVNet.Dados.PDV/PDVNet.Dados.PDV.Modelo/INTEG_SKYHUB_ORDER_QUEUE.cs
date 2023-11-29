using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_SKYHUB_ORDER_QUEUE
{
	[Key]
	[Column(Order = 0)]
	public byte SOQ_CONFIGURACAO { get; set; }

	[StringLength(30)]
	[Key]
	[Column(Order = 1)]
	public string SOQ_CODE { get; set; }

	[StringLength(20)]
	[Key]
	[Column(Order = 2)]
	public string SOQ_STATUS_CODE { get; set; }

	public DateTime? SOQ_CADASTRO_FILA { get; set; }

	public DateTime? SOQ_UPDATED_AT { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string SOQ_DADOS { get; set; }

	public bool? SOQ_INTEGRADO { get; set; }
}
