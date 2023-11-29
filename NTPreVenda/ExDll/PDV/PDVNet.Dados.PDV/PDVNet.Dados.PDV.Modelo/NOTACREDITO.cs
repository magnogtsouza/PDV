using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NOTACREDITO")]
public class NOTACREDITO
{
	[Key]
	[StringLength(20)]
	public string NOC_DOC { get; set; }

	public short? NOC_FILIAL { get; set; }

	public double? NOC_VALOR { get; set; }

	public DateTime? NOC_CADASTRO { get; set; }

	public DateTime? NOC_ATUALIZACAO { get; set; }

	public byte? NOC_UTILIZADO { get; set; }

	public DateTime? NOC_UTILIZACAO { get; set; }

	[StringLength(8)]
	public string NOC_MATRICULA { get; set; }

	public bool? NOC_INATIVO { get; set; }
}
