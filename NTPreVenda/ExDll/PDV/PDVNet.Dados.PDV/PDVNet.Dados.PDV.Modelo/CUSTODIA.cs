using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CUSTODIA")]
public class CUSTODIA
{
	[Key]
	[StringLength(3)]
	public string CUS_CODIGO { get; set; }

	public short? CUS_BANCO { get; set; }

	public short? CUS_INICIO { get; set; }

	public short? CUS_FINAL { get; set; }

	[StringLength(30)]
	public string CUS_DESCRICAO { get; set; }

	public bool? CUS_INATIVO2 { get; set; }
}
