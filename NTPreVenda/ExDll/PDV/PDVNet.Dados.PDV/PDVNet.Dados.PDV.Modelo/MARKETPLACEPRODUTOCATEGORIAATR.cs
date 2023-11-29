using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class MARKETPLACEPRODUTOCATEGORIAATRIBUTO
{
	[Key]
	public int MCA_MARKETPLACEPRODUTOCATEGORIA { get; set; }

	public bool? MCA_TIPO { get; set; }

	[StringLength(14)]
	public string MCA_PDV_CODIGO { get; set; }

	[StringLength(10)]
	public string MCA_ATRIBUTO { get; set; }

	[StringLength(100)]
	public int? MCA_VALOR { get; set; }
}
