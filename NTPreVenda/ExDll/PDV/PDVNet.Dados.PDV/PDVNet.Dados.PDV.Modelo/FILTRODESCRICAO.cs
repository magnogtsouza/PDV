using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILTRODESCRICAO")]
public class FILTRODESCRICAO
{
	[Key]
	[Column(Order = 0)]
	public byte FID_REDE { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte FID_FILTRO { get; set; }

	[StringLength(15)]
	public string FID_DESCRICAO { get; set; }
}
