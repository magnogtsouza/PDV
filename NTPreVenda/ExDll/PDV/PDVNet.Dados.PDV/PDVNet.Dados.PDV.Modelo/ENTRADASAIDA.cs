using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ENTRADASAIDA")]
public class ENTRADASAIDA
{
	public int ENT_FILIAL { get; set; }

	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string ENT_PRODUTO { get; set; }

	public double? ENT_QUANTIDADE { get; set; }

	public double? ENT_VALOR { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string ENT_DOC { get; set; }
}
