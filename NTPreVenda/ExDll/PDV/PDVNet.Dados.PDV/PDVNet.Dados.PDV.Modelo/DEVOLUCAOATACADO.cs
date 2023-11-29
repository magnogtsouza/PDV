using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DEVOLUCAOATACADO")]
public class DEVOLUCAOATACADO
{
	[StringLength(6)]
	public string DEV_CODIGO { get; set; }

	public int? DEV_FILIAL { get; set; }

	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string DEV_PRODUTO { get; set; }

	[Key]
	[Column(Order = 1)]
	public DateTime DEV_DATA { get; set; }

	public double? DEV_QUANTIDADE { get; set; }
}
