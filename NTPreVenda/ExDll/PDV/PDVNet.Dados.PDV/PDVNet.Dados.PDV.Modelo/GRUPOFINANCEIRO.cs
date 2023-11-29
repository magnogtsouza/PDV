using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("GRUPOFINANCEIRO")]
public class GRUPOFINANCEIRO
{
	[Key]
	[StringLength(2)]
	public string GRU_CODIGO { get; set; }

	[StringLength(20)]
	public string GRU_DESCRICAO { get; set; }

	[StringLength(2)]
	public string GRU_FISCAL { get; set; }

	public bool? GRU_INATIVO { get; set; }

	[StringLength(8)]
	public string GRU_MATRICULA { get; set; }

	public DateTime? GRU_CADASTRO { get; set; }

	public DateTime? GRU_ATUALIZACAO { get; set; }
}
