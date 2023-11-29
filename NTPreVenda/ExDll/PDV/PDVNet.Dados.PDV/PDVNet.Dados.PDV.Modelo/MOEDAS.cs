using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class MOEDAS
{
	[Key]
	public byte MOE_CODIGO { get; set; }

	[StringLength(10)]
	public string MOE_DESCRICAO { get; set; }

	public DateTime? MOE_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string MOE_MATRICULA { get; set; }
}
