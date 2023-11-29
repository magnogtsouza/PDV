using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_MAGENTO_PRODUTO
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
	[StringLength(14)]
	public string PRO_PDV_CODIGO { get; set; }

	public DateTime? PRO_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string MAT_REFERENCIA { get; set; }
}
