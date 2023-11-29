using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SETOR")]
public class SETOR
{
	[Key]
	[StringLength(4)]
	public string SET_CODIGO { get; set; }

	[StringLength(2)]
	public string SET_FASE { get; set; }

	[StringLength(100)]
	public string SET_DESCRICAO { get; set; }

	public bool? SET_INATIVO { get; set; }

	public DateTime? SET_CADASTRO { get; set; }

	[StringLength(8)]
	public string SET_MATRICULA { get; set; }

	public byte? SET_REDE { get; set; }

	public DateTime? SET_ATUALIZACAO { get; set; }
}
