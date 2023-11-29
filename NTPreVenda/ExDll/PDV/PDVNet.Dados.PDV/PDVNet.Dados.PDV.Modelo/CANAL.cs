using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class CANAL
{
	[Key]
	public short? CAN_CODIGO { get; set; }

	[StringLength(30)]
	public string CAN_DESCRICAO { get; set; }

	public DateTime? CAN_ATUALIZACAO { get; set; }

	public bool? CAN_INATIVO { get; set; }

	public DateTime? CAN_CADASTRO { get; set; }

	[StringLength(8)]
	public string CAN_MATRICULA { get; set; }
}
