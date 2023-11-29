using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_XTECH_ORDER
{
	[Key]
	[Column(Order = 0)]
	public byte ORD_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string ORD_PDV_DOC { get; set; }

	public int? ORD_ID { get; set; }

	[StringLength(30)]
	public string ORD_NUMBER { get; set; }

	public DateTime? ORD_ULTIMA_EXPORTACAO { get; set; }
}
