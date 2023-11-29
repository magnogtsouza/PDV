using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class PRODUTOSOLICITACAO
{
	[Key]
	public Guid PSO_ID { get; set; }

	public DateTime? PSO_DATA { get; set; }

	[StringLength(14)]
	public string PSO_PRODUTO { get; set; }

	[StringLength(8)]
	public string PSO_MATRICULA { get; set; }

	[StringLength(8)]
	public string PSO_MATRICULA_ATENDIMENTO { get; set; }

	public short? PSO_STATUS { get; set; }
}
