using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class BONUS
{
	[Key]
	[StringLength(9)]
	public string BON_BONUS { get; set; }

	public short BON_CODIGO { get; set; }

	public DateTime? BON_VALIDADE { get; set; }

	public double? BON_PONTOS { get; set; }

	public double? BON_VALOR { get; set; }

	public bool? BON_EXCLUIDO { get; set; }

	public DateTime? BON_D_USO { get; set; }

	public DateTime? BON_D_EXCLUIDO { get; set; }

	[StringLength(8)]
	public string BON_MATRICULA { get; set; }

	public DateTime? BON_ATUALIZACAO { get; set; }

	[StringLength(16)]
	public string BON_CODIGON { get; set; }

	public double? BON_EXTRA { get; set; }

	[StringLength(20)]
	public string BON_DOC { get; set; }

	public DateTime? BON_INICIO_UTILIZACAO { get; set; }

	public short? BON_FILIAL_ORIGEM { get; set; }

	public DateTime? BON_CADASTRO { get; set; }
}
