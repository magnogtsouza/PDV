using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_WOOCOMMERCE_PRODUCT
{
	[Key]
	[Column(Order = 0)]
	public byte PRO_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PRO_ID { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte PRO_PDV_REDE { get; set; }

	[Key]
	[Column(Order = 3)]
	[StringLength(12)]
	public string PRO_PDV_REFERENCIA { get; set; }

	public DateTime? PRO_ULTIMA_EXPORTACAO { get; set; }
}
