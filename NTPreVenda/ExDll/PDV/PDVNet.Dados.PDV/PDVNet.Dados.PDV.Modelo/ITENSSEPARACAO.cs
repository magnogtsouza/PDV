using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITENSSEPARACAO")]
public class ITENSSEPARACAO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int ITS_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(6)]
	public string ITS_PEDIDO { get; set; }

	[StringLength(16)]
	public string ITS_CODIGON { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(14)]
	public string ITS_PRODUTO { get; set; }

	public double? ITS_QTD { get; set; }

	public byte? ITS_FATURADO { get; set; }

	public DateTime? ITS_FATURAMENTO { get; set; }

	public bool? ITS_INATIVO { get; set; }

	public double? ITS_PRECO { get; set; }
}
