using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CARTEIRABANCO")]
public class CARTEIRABANCO
{
	[Key]
	[Column(Order = 0)]
	public byte CAB_CODIGO_CARTEIRA { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte CAB_SEQ { get; set; }

	[StringLength(3)]
	public string CAB_BANCO { get; set; }

	[StringLength(3)]
	public string CAB_CARTEIRA_BANCO { get; set; }

	public DateTime? CAB_ATUALIZACAO { get; set; }

	public byte? CAB_INATIVO { get; set; }
}
