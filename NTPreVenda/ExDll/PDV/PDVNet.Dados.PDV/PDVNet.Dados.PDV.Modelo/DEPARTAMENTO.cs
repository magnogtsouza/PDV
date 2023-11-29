using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DEPARTAMENTO")]
public class DEPARTAMENTO
{
	[Key]
	[Column(Order = 0)]
	public byte DEP_CODIGO { get; set; }

	[StringLength(30)]
	public string DEP_DESCRICAO { get; set; }

	[StringLength(8)]
	public string DEP_MATRICULA { get; set; }

	public DateTime? DEP_CADASTRO { get; set; }

	public DateTime? DEP_ATUALIZACAO { get; set; }

	public bool? DEP_INATIVO { get; set; }

	[NotMapped]
	public string UsuarioNome { get; set; }
}
