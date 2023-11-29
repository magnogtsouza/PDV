using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DEPENDENTE")]
public class DEPENDENTE
{
	[StringLength(16)]
	public string DEP_CODIGON { get; set; }

	[Key]
	public byte DEP_CODIGO { get; set; }

	[StringLength(70)]
	public string DEP_NOME { get; set; }

	public DateTime? DEP_NASCIMENTO { get; set; }

	public byte? DEP_PARENTESCO { get; set; }

	public DateTime? DEP_CADASTRO { get; set; }

	public DateTime? DEP_ATUALIZACAO { get; set; }

	public bool? DEP_INATIVO { get; set; }
}
