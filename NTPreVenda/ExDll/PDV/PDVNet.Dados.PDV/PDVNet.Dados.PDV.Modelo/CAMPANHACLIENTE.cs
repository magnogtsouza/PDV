using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAMPANHACLIENTE")]
public class CAMPANHACLIENTE
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CAC_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(16)]
	public string CAC_CODIGON { get; set; }

	public DateTime? CAC_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CAC_MATRICULA { get; set; }

	public bool? CAC_INATIVO { get; set; }
}
