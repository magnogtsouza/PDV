using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONTADORFISCAL")]
public class CONTADORFISCAL
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CON_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte CON_CAIXA { get; set; }

	[Key]
	[Column(Order = 2)]
	public DateTime CON_DATA { get; set; }

	[StringLength(6)]
	public string CON_REDUCAO { get; set; }

	[StringLength(6)]
	public string CON_REINICIO { get; set; }

	public double? CON_TOTALIZADOR_GERAL { get; set; }

	public double? CON_BRUTA { get; set; }

	public double? CON_CANCELAMENTO { get; set; }

	public double? CON_ACRESCIMO { get; set; }

	public double? CON_DESCONTO { get; set; }

	public byte? CON_IMPRESSORA { get; set; }

	[StringLength(6)]
	public string CON_COOINICIAL { get; set; }

	[StringLength(6)]
	public string CON_COOFINAL { get; set; }

	[StringLength(6)]
	public string CON_COO { get; set; }

	public DateTime? CON_DATA_REDUCAO { get; set; }

	public int? CON_ASSINA { get; set; }

	[StringLength(8)]
	public string CON_US_ALTERACAO { get; set; }

	[StringLength(20)]
	public string CON_SERIAL { get; set; }

	public DateTime? CON_ATUALIZACAO { get; set; }
}
