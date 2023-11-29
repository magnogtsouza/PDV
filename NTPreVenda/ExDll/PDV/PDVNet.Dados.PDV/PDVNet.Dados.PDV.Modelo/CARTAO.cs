using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CARTAO")]
public class CARTAO
{
	[Key]
	public byte CAR_CODIGO { get; set; }

	[StringLength(30)]
	public string CAR_DESCRICAO { get; set; }

	public byte? CAR_REDE { get; set; }

	public bool? CAR_ATIVO { get; set; }

	public byte? CAR_TIPO2 { get; set; }

	public DateTime? CAR_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CAR_MATRICULA { get; set; }

	public string CAR_CNPJ { get; set; }

	public string CAR_IDENTIFICACAO { get; set; }

	public bool? CAR_FIXO { get; set; }

	public bool? CAR_ARREDONDAMENTO_PRIMEIRA_PARCELA { get; set; }

	public byte? CAR_OPERADORA { get; set; }

	public bool? CAR_RECEBIMENTO_FIXO { get; set; }
}
