using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_MAGENTO_REFERENCIA
{
	[Key]
	[Column(Order = 0)]
	public byte REF_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int REF_ID { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte REF_PDV_REDE { get; set; }

	[Key]
	[Column(Order = 3)]
	[StringLength(12)]
	public string REF_PDV_REFERENCIA { get; set; }

	public DateTime? REF_ULTIMA_EXPORTACAO { get; set; }
}
