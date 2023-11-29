using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class BONUSEXTRATO
{
	[Key]
	public string BEX_BONUS { get; set; }

	[Key]
	public short BEX_SEQ { get; set; }

	public double? BEX_VALOR { get; set; }

	public short? BEX_STATUS { get; set; }

	public string BEX_DOC { get; set; }

	public DateTime? BEX_ATUALIZACAO { get; set; }

	public DateTime? BEX_DATA { get; set; }
}
