using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("METAVALOR")]
public class METAVALOR
{
	[Key]
	[Column(Order = 0)]
	public short MET_META { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(1)]
	public string MET_SEQ { get; set; }

	public double? MET_COMISSAO { get; set; }

	public double? MET_VALOR1 { get; set; }

	public double? MET_VALOR2 { get; set; }

	public double? MET_MAXIMO { get; set; }

	public double? MET_MINIMO { get; set; }
}
