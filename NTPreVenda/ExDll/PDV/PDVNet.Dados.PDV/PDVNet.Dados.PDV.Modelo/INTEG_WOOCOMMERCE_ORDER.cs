using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_WOOCOMMERCE_ORDER
{
	[Key]
	[Column(Order = 0)]
	public byte ORD_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int? ORD_ID { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(20)]
	public string ORD_PDV_DOC { get; set; }
}
