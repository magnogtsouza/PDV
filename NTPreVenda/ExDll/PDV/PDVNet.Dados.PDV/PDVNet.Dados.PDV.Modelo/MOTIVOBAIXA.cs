using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MOTIVOBAIXA")]
public class MOTIVOBAIXA
{
	[Key]
	[StringLength(3)]
	public string MOT_CODIGO { get; set; }

	[StringLength(100)]
	public string MOT_DESCRICAO { get; set; }

	public bool? MOT_INATIVO { get; set; }

	public DateTime? MOT_CADASTRO { get; set; }
}
