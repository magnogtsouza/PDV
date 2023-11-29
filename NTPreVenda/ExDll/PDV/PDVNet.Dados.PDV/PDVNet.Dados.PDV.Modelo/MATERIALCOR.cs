using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MATERIALCOR")]
public class MATERIALCOR
{
	[Key]
	[StringLength(12)]
	public string MAT_CODIGO { get; set; }

	[StringLength(8)]
	public string MAT_MATERIAL { get; set; }

	[StringLength(4)]
	public string MAT_COR { get; set; }

	[StringLength(20)]
	public string MAT_REFERENCIA { get; set; }

	public DateTime? MAT_CADASTRO { get; set; }

	[StringLength(8)]
	public string MAT_MATRICULA { get; set; }

	public bool? MAT_INATIVO { get; set; }

	public DateTime? MAT_ATUALIZACAO { get; set; }
}
