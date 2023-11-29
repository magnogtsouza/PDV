using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("LANCAMENTOCONTA")]
public class LANCAMENTOCONTA
{
	[Key]
	[StringLength(6)]
	public string LAN_CODIGO { get; set; }

	public short LAN_CONTA { get; set; }

	public DateTime? LAN_DATA { get; set; }

	[StringLength(4)]
	public string LAN_CCUSTO { get; set; }

	public short LAN_CLASSIFICACAO { get; set; }

	public byte? LAN_TIPO { get; set; }

	public double? LAN_VALOR { get; set; }

	[StringLength(8)]
	public string LAN_MATRICULA { get; set; }

	[StringLength(5)]
	public string LAN_HORA { get; set; }

	[StringLength(50)]
	public string LAN_OBS { get; set; }

	[StringLength(1)]
	public string LAN_STATUS { get; set; }

	public DateTime? LAN_CADASTRO { get; set; }

	public int? LAN_CHEQUE { get; set; }

	public byte? LAN_ESTORNO { get; set; }

	public byte? LAN_TIPO2 { get; set; }

	public short? LAN_FILIAL { get; set; }

	public DateTime? LAN_COMPETENCIA { get; set; }
}
