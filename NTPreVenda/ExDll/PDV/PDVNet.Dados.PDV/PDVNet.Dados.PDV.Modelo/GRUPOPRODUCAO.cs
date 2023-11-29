using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("GRUPOPRODUCAO")]
public class GRUPOPRODUCAO
{
	[Key]
	[StringLength(2)]
	public string GRP_CODIGO { get; set; }

	[StringLength(100)]
	public string GRP_DESCRICAO { get; set; }

	public bool? GRP_INATIVO { get; set; }

	public DateTime? GRP_CADASTRO { get; set; }

	[StringLength(8)]
	public string GRP_MATRICULA { get; set; }

	public byte? GRP_REDE { get; set; }

	public DateTime? GRP_ATUALIZACAO { get; set; }
}
