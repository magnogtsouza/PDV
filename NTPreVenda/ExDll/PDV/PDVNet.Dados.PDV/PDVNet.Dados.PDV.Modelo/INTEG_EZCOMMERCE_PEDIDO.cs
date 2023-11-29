using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_EZCOMMERCE_PEDIDO
{
	[Key]
	[Column(Order = 0)]
	public byte PED_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string PED_PDV_DOC { get; set; }

	public int? PED_ID { get; set; }

	public DateTime? PED_ULTIMA_EXPORTACAO { get; set; }
}
