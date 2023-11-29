using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("METAVENDEDOR")]
public class METAVENDEDOR
{
	[Key]
	[Column(Order = 0)]
	public short MET_META { get; set; }

	[Key]
	[Column(Order = 1)]
	public DateTime MET_DIA { get; set; }

	[StringLength(8)]
	public string MET_VENDEDOR { get; set; }

	public double? MET_VALOR { get; set; }
}
