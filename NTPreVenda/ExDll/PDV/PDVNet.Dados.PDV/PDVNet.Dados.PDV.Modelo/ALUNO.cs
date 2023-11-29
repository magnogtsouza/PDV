using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ALUNO")]
public class ALUNO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(8)]
	public string ALU_CODIGO { get; set; }

	[StringLength(150)]
	public string ALU_NOME { get; set; }

	public short? ALU_FILIAL { get; set; }

	public short? ALU_TURMA { get; set; }

	[StringLength(8)]
	public string ALU_MATRICULA { get; set; }

	public DateTime? ALU_CADASTRO { get; set; }

	public DateTime? ALU_ATUALIZACAO { get; set; }

	public bool? ALU_INATIVO { get; set; }

	[NotMapped]
	public string UsuarioNome { get; set; }
}
