using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class BANCOS
{
	[Key]
	public short BAN_NUMERO { get; set; }

	[StringLength(50)]
	public string BAN_DESCRICAO { get; set; }

	public DateTime? BAN_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string BAN_MATRICULA { get; set; }

	public bool? BAN_INATIVO { get; set; }

	public int BAN_ORDEM { get; set; }
}
