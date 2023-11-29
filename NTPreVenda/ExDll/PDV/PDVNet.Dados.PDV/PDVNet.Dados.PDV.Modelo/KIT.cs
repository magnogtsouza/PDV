using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class KIT
{
	[Key]
	[StringLength(8)]
	public string KIT_CODIGO { get; set; }

	[StringLength(100)]
	public string KIT_DESCRICAO { get; set; }

	public DateTime? KIT_CADASTRO { get; set; }

	public DateTime? KIT_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string KIT_MATRICULA { get; set; }

	public bool KIT_INATIVO { get; set; }

	[NotMapped]
	public string ExtensaoUsuarioNome { get; set; }
}
