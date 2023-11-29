using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TURMA")]
public class TURMA
{
	[Key]
	[Column(Order = 0)]
	public short TUR_CODIGO { get; set; }

	[StringLength(50)]
	public string TUR_DESCRICAO { get; set; }

	public DateTime? TUR_CADASTRO { get; set; }

	public DateTime? TUR_ATUALIZACAO { get; set; }

	public bool? TUR_INATIVA { get; set; }

	[StringLength(8)]
	public string TUR_MATRICULA { get; set; }

	[NotMapped]
	public string ExtensaoUsuarioNome { get; set; }
}
