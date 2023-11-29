using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ITICONTRATO
{
	[Key]
	[Column(Order = 0)]
	public byte ITI_CODIGO { get; set; }

	public byte? ITI_REDE { get; set; }

	[StringLength(14)]
	public string ITI_IDCLIENTE { get; set; }

	[StringLength(36)]
	public string ITI_IDCONTRATO { get; set; }

	public bool? ITI_INATIVO { get; set; }

	public DateTime? ITI_CADASTRO { get; set; }

	[StringLength(8)]
	public string ITI_MATRICULA { get; set; }

	public DateTime? ITI_ATUALIZACAO { get; set; }

	[NotMapped]
	public string ExtensaoUsuarioNome { get; set; }
}
