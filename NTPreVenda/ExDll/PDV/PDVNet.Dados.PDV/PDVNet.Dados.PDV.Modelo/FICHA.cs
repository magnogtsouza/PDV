using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FICHA")]
public class FICHA
{
	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string FIC_PRODUTO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(8)]
	public string FIC_MATERIAL { get; set; }

	public double? FIC_QTD { get; set; }

	public double? FIC_COTACAO { get; set; }

	public double? FIC_CUSTO { get; set; }

	public double? FIC_VENDA { get; set; }

	public DateTime? FIC_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string FIC_MATRICULA { get; set; }
}
