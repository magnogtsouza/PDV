using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class CAIXAPIX
{
	[Key]
	public string CAP_DOC { get; set; }

	[Key]
	public byte CAP_SEQ { get; set; }

	public Guid? CAP_PIX { get; set; }

	public short? CAP_STATUS { get; set; }

	public int? CAP_SEQ_TEF { get; set; }

	[MaxLength(12)]
	public string CAP_NSU { get; set; }

	public Guid? CAP_TRANSACAO { get; set; }
}
