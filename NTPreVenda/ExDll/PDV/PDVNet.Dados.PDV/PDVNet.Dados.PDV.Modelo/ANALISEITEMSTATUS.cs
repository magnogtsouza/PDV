using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ANALISEITEMSTATUS")]
public class ANALISEITEMSTATUS
{
	[Key]
	[Column(Order = 0)]
	public int ANS_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short ANS_SEQITEM { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte ANS_SEQ { get; set; }

	public DateTime? ANS_CADASTRO { get; set; }

	[StringLength(8)]
	public string ANS_MATRICULA { get; set; }

	public byte? ANS_STATUS { get; set; }

	public byte? ANS_OBSERVACAO { get; set; }
}
