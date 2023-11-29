using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FASE")]
public class FASE
{
	[Key]
	[StringLength(2)]
	public string FAS_CODIGO { get; set; }

	[StringLength(100)]
	public string FAS_DESCRICAO { get; set; }

	public bool? FAS_INATIVO { get; set; }

	public DateTime? FAS_CADASTRO { get; set; }

	[StringLength(8)]
	public string FAS_MATRICULA { get; set; }

	public byte? FAS_REDE { get; set; }

	public DateTime? FAS_ATUALIZACAO { get; set; }
}
