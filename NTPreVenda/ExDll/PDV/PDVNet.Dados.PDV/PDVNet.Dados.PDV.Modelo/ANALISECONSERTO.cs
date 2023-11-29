using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ANALISECONSERTO")]
public class ANALISECONSERTO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int ANA_ID { get; set; }

	public int? ANA_ID_RETAGUARDA { get; set; }

	[StringLength(20)]
	public string ANA_DOC { get; set; }

	public short? ANA_FILIAL { get; set; }

	[StringLength(16)]
	public string ANA_CODIGON { get; set; }

	public DateTime? ANA_CADASTRO { get; set; }

	public DateTime? ANA_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string ANA_MATRICULA { get; set; }

	public bool? ANA_INATIVO { get; set; }
}
