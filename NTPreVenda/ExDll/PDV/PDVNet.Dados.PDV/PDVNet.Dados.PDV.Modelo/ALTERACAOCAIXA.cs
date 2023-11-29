using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ALTERACAOCAIXA")]
public class ALTERACAOCAIXA
{
	[StringLength(8)]
	public string ALT_VENDEDOR { get; set; }

	[StringLength(8)]
	public string ALT_VENDEDOR2 { get; set; }

	public DateTime? ALT_DATA { get; set; }

	[Key]
	[StringLength(20)]
	public string ALT_DOC { get; set; }
}
