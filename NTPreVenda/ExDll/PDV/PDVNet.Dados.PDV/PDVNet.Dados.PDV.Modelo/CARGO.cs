using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CARGO")]
public class CARGO
{
	[Key]
	[Column(Order = 0)]
	public byte CAR_CODIGO { get; set; }

	[StringLength(30)]
	public string CAR_DESCRICAO { get; set; }

	[StringLength(8)]
	public string CAR_MATRICULA { get; set; }

	public DateTime? CAR_CADASTRO { get; set; }

	public DateTime? CAR_ATUALIZACAO { get; set; }

	public bool? CAR_INATIVO { get; set; }
}
