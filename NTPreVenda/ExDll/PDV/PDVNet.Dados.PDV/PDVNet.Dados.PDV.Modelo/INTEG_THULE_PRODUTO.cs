using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_THULE_PRODUTO
{
	[Key]
	[Column(Order = 0)]
	public byte PRO_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string PRO_PDV_CODIGO { get; set; }

	public DateTime? PRO_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string REF_REFERENCIA_FORNECEDOR { get; set; }

	[NotMapped]
	public double? SAL_SALDO { get; set; }

	[NotMapped]
	public double? COMPROMETIDO { get; set; }
}
