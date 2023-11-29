using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_WOOCOMMERCE_VARIANT
{
	[Key]
	[Column(Order = 0)]
	public byte VAR_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int VAR_ID { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(14)]
	public string VAR_PDV_CODIGO { get; set; }

	public DateTime? VAR_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public int? VAR_PRODUCT_ID { get; set; }

	[NotMapped]
	public string VAR_PDV_REFERENCIA { get; set; }
}
