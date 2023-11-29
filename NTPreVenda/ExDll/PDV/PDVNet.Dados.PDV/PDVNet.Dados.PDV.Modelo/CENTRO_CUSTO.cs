using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class CENTRO_CUSTO
{
	[Key]
	[StringLength(4)]
	public string CEN_CODIGO { get; set; }

	[StringLength(30)]
	public string CEN_DESCRICAO { get; set; }

	public bool? CEN_ATIVO { get; set; }

	public bool? CEN_INATIVO { get; set; }

	public DateTime? CEN_CADASTRO { get; set; }

	public DateTime? CEN_ATUALIZACAO { get; set; }
}
