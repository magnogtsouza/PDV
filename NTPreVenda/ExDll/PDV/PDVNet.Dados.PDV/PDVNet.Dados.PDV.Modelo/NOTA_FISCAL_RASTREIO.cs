using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NOTA_FISCAL_RASTREIO")]
public class NOTA_FISCAL_RASTREIO
{
	[Key]
	[StringLength(20)]
	public string NRA_DOC { get; set; }

	[StringLength(20)]
	public string NRA_CODIGO_RASTREIO { get; set; }

	public DateTime? NRA_CADASTRO { get; set; }

	public DateTime? NRA_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string NRA_MATRICULA { get; set; }
}
