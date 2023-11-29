using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MATERIAPRIMA")]
public class MATERIAPRIMA
{
	[Key]
	public short MAP_CODIGO { get; set; }

	[StringLength(30)]
	public string MAP_DESCRICAO { get; set; }

	public bool? MAP_INATIVO2 { get; set; }
}
