using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class TabelaTeste
{
	[Key]
	[Column(Order = 0)]
	public int? Codigo { get; set; }

	[StringLength(10)]
	public string Descricao { get; set; }
}
