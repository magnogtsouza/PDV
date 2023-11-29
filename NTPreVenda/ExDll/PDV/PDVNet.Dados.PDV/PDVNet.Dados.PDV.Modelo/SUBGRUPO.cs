using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SUBGRUPO")]
public class SUBGRUPO
{
	[Key]
	[StringLength(4)]
	public string SUB_CODIGO { get; set; }

	[StringLength(2)]
	public string SUB_GRUPO { get; set; }

	[StringLength(100)]
	public string SUB_DESCRICAO { get; set; }

	public bool? SUB_INATIVO { get; set; }

	public DateTime? SUB_CADASTRO { get; set; }

	[StringLength(8)]
	public string SUB_MATRICULA { get; set; }

	public byte? SUB_REDE { get; set; }

	public DateTime? SUB_ATUALIZACAO { get; set; }
}
