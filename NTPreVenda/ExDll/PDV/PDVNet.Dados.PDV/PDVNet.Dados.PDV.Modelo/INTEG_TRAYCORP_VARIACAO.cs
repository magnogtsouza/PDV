using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_TRAYCORP_VARIACAO
{
	[Key]
	[Column(Order = 0)]
	public byte VAR_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string VAR_PDV_CODIGO { get; set; }

	public int? VAR_ID { get; set; }

	public DateTime? VAR_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public int? ExtensaoProductId { get; set; }
}
