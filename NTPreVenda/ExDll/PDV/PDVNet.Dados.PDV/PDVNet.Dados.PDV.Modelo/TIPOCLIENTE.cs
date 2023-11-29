using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TIPOCLIENTE")]
public class TIPOCLIENTE
{
	[Key]
	public byte TIP_CODIGO { get; set; }

	[StringLength(30)]
	public string TIP_DESCRICAO { get; set; }

	public bool? TIP_INATIVO { get; set; }

	public DateTime? TIP_CADASTRO { get; set; }

	[StringLength(8)]
	public string TIP_MATRICULA { get; set; }

	public DateTime? TIP_ATUALIZACAO { get; set; }

	public byte? TIP_EXIBE_WEB { get; set; }
}
