using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_MAGENTO_CUSTOMER
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int CUS_ID { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(16)]
	public string CUS_PDV_CODIGON { get; set; }
}
