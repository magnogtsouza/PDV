using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAMPANHA")]
public class CAMPANHA
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CAM_CODIGO { get; set; }

	[StringLength(50)]
	public string CAM_DESCRICAO { get; set; }

	public DateTime? CAM_INICIO { get; set; }

	public DateTime? CAM_FINAL { get; set; }

	public DateTime? CAM_CADASTRO { get; set; }

	public DateTime? CAM_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CAM_MATRICULA { get; set; }

	public bool? CAM_INATIVO { get; set; }
}
