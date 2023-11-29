using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAIXAAUTORIZA")]
public class CAIXAAUTORIZA
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string CAA_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte CAA_SEQ { get; set; }

	public byte? CAA_OPERACAO { get; set; }

	public DateTime? CAA_DATA { get; set; }

	[StringLength(8)]
	public string CAA_MATRICULA { get; set; }
}
