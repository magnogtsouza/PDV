using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class ECF_CAIXA
{
	[Required]
	public short? CAI_FILIAL { get; set; }

	public DateTime? CAI_DATA { get; set; }

	public double? CAI_VALOR { get; set; }

	[StringLength(6)]
	public string CAI_NOTA { get; set; }

	public double? CAI_DESCONTO { get; set; }

	[StringLength(1)]
	public string CAI_RETIRADA { get; set; }

	public double? CAI_VENDIDAS { get; set; }

	[StringLength(8)]
	public string CAI_MATRICULA { get; set; }

	[StringLength(1)]
	public string CAI_STATUS { get; set; }

	public byte? CAI_CAIXA { get; set; }

	[StringLength(16)]
	public string CAI_CODIGON { get; set; }

	[StringLength(20)]
	public string CAI_SERIAL { get; set; }

	[StringLength(3)]
	public string CAI_SERIE { get; set; }

	[StringLength(2)]
	public string CAI_SUBSERIE { get; set; }

	[StringLength(6)]
	public string CAI_CCF { get; set; }

	public int? CAI_ASSINA { get; set; }

	[Key]
	[StringLength(20)]
	public string CAI_DOC { get; set; }

	public bool? CAI_INATIVA { get; set; }

	public byte? CAI_TIPO { get; set; }
}
