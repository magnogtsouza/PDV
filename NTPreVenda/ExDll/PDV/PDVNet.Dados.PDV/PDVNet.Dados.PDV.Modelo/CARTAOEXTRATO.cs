using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CARTAOEXTRATO")]
public class CARTAOEXTRATO
{
	[Key]
	[Column(Order = 0)]
	[NotMapped]
	public int CAE_ID { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	[StringLength(10)]
	public string CAE_EXTRATO_ID { get; set; }

	[StringLength(10)]
	public string CAE_ESTABELECIMENTO { get; set; }

	[StringLength(10)]
	public string CAE_CONTA_ID { get; set; }

	[StringLength(50)]
	public string CAE_CARTAO_ID { get; set; }

	public double? CAE_VALOR { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public DateTime? CAE_DATA { get; set; }

	public DateTime? CAE_ATUALIZACAO { get; set; }
}
