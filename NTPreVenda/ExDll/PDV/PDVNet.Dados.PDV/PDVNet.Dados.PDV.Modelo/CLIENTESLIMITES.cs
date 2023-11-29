using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CLIENTESLIMITES
{
	[Key]
	[Column(Order = 0)]
	[StringLength(16)]
	public string CLL_CODIGON { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CLL_SEQ { get; set; }

	public double? CLL_VALOR { get; set; }

	public DateTime? CLL_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CLL_MATRICULA { get; set; }
}
