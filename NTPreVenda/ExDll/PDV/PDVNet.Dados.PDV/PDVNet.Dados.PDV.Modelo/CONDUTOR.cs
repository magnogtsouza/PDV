using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONDUTOR")]
public class CONDUTOR
{
	[Key]
	[Column(Order = 0)]
	public short CON_CODIGO { get; set; }

	[StringLength(70)]
	public string CON_NOME { get; set; }

	[StringLength(11)]
	public string CON_CPF { get; set; }

	public DateTime? CON_CADASTRO { get; set; }

	public DateTime? CON_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CON_MATRICULA { get; set; }

	public bool? CON_INATIVO { get; set; }

	[NotMapped]
	public string ExtensaoUsuarioNome { get; set; }
}
