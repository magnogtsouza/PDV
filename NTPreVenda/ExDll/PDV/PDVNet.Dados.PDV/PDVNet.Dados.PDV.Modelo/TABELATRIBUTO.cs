using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TABELATRIBUTO")]
public class TABELATRIBUTO
{
	[Key]
	public byte TAT_CODIGO { get; set; }

	[StringLength(40)]
	public string TAT_DESCRICAO { get; set; }

	public bool? TAT_INATIVO { get; set; }

	public DateTime? TAT_CADASTRO { get; set; }

	public DateTime? TAT_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string TAT_MATRICULA { get; set; }

	public byte? TAT_TIPO { get; set; }

	public double? TAT_VALOR { get; set; }
}
