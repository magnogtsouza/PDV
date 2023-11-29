using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SERVICOREGIMEIMPOSTO")]
public class SERVICOREGIMEIMPOSTO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(12)]
	public string SRI_REFERENCIA { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte SRI_REDE { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte SRI_REGIME { get; set; }

	public double? SRI_COFINS { get; set; }

	public double? SRI_PIS { get; set; }

	public double? SRI_CSLL { get; set; }

	public double? SRI_IRPJ { get; set; }

	public double? SRI_ISS { get; set; }

	[NotMapped]
	public string CodigoMaterial { get; set; }
}
