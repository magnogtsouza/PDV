using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CEST")]
public class CEST
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CES_CODIGO { get; set; }

	public string CES_DESCRICAO { get; set; }

	[StringLength(7)]
	public string CES_CEST { get; set; }

	public DateTime? CES_CADASTRO { get; set; }

	public DateTime? CES_ATUALIZACAO { get; set; }

	public bool? CES_INATIVO { get; set; }

	[StringLength(8)]
	public string CES_MATRICULA { get; set; }

	public double? CES_MVA_INTERNA { get; set; }

	public double? CES_MVA_INTERESTADUAL_7 { get; set; }

	public double? CES_MVA_INTERESTADUAL_12 { get; set; }

	public double? CES_MVA_INTERESTADUAL_4 { get; set; }
}
