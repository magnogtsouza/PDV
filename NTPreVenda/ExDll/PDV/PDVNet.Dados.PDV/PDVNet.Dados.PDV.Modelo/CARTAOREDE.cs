using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CARTAOREDE")]
public class CARTAOREDE
{
	[Key]
	public byte CAD_CODIGO { get; set; }

	[StringLength(50)]
	public string CAD_DESCRICAO { get; set; }

	public DateTime? CAD_ATUALIZACAO { get; set; }

	public bool? CAD_INATIVO { get; set; }

	[StringLength(14)]
	public string CAD_CNPJ { get; set; }
}
