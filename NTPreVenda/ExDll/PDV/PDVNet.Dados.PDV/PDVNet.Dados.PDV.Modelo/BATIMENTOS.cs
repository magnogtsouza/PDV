using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class BATIMENTOS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(6)]
	public string BAT_ROMANEIO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int BAT_FILIAL { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int BAT_FILIAL2 { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte BAT_TIPO { get; set; }

	[Key]
	[Column(Order = 4)]
	[StringLength(14)]
	public string BAT_PRODUTO { get; set; }

	public double? BAT_QTD { get; set; }
}
