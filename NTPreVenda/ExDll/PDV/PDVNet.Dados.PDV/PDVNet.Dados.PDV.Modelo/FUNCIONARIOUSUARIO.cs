using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FUNCIONARIOUSUARIO")]
public class FUNCIONARIOUSUARIO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(8)]
	public string FUU_FUNCIONARIO_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(8)]
	public string FUU_USUARIO_CODIGO { get; set; }

	public DateTime? FUU_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string FUU_MATRICULA { get; set; }

	public bool? FUU_INATIVO { get; set; }
}
