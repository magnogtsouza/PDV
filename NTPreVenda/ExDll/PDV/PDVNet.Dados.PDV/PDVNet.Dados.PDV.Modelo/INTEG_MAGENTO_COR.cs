using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_MAGENTO_COR
{
	[Key]
	[Column(Order = 0)]
	public byte COR_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short COR_PDV_CODIGO { get; set; }

	public DateTime? COR_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string COR_DESCRICAO { get; set; }
}
