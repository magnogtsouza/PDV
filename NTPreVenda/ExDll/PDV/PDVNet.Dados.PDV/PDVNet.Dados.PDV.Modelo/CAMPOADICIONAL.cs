using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAMPOADICIONAL")]
public class CAMPOADICIONAL
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CAM_CODIGO { get; set; }

	public short? CAM_TELA { get; set; }

	[StringLength(30)]
	public string CAM_DESCRICAO { get; set; }

	public byte? CAM_TIPO { get; set; }

	public byte? CAM_TAMANHO { get; set; }

	public byte? CAM_OBRIGATORIO { get; set; }

	public DateTime? CAM_CADASTRO { get; set; }

	public DateTime? CAM_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CAM_MATRICULA { get; set; }

	public bool? CAM_INATIVO { get; set; }

	[StringLength(30)]
	public string CAM_NOME_CAMPO { get; set; }

	public byte? CAM_EXPORTAR_LOJA { get; set; }
}
