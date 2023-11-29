using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_FOURMIDDLEWARE_ORDER
{
	[Key]
	[Column(Order = 0)]
	public byte ORD_CONFIGURACAO { get; set; }

	[Key]
	[StringLength(16)]
	[Column(Order = 1)]
	public string ORD_PDV_DOC { get; set; }

	[Column(Order = 2)]
	public long? ORD_MIDDLEWARE_ORDER_ID { get; set; }

	[StringLength(30)]
	public string ORD_ORIGN_ORDER_ID { get; set; }

	[StringLength(30)]
	public string ORD_PLATAFORM_ORIGN_ORDER { get; set; }

	[StringLength(30)]
	public string ORD_PLATAFORM_TYPE_ORIGN_ORDER { get; set; }

	public DateTime? ORD_ULTIMA_EXPORTACAO { get; set; }
}
