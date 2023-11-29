using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class TRANSFERENCIAITEM
{
	[Key]
	[Column(Order = 0)]
	public int TRI_ID { get; set; }

	[Key]
	[Column(Order = 1)]
	public short TRI_SEQ { get; set; }

	[StringLength(14)]
	public string TRI_PRODUTO { get; set; }

	public double? TRI_QUANTIDADE { get; set; }

	[StringLength(20)]
	public string TRI_REMANEJAMENTO { get; set; }

	public byte? TRI_RAZAO { get; set; }

	public double? TRI_QUANTIDADE_BATIMENTO { get; set; }
}
