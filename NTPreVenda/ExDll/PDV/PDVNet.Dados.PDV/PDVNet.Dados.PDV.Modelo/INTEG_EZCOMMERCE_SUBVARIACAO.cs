using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_EZCOMMERCE_SUBVARIACAO
{
	[Key]
	[Column(Order = 0)]
	public byte SUB_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string SUB_PDV_CODIGO { get; set; }

	public int? SUB_ID { get; set; }

	public DateTime? SUB_ULTIMA_EXPORTACAO { get; set; }
}
