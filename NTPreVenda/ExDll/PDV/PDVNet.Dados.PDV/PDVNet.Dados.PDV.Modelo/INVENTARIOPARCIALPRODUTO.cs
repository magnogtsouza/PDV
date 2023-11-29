using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class INVENTARIOPARCIALPRODUTO
{
	[Key]
	public short IPP_INVENTARIO { get; set; }

	[Key]
	[StringLength(14)]
	public string IPP_PRODUTO { get; set; }

	[Key]
	public short IPP_FILIAL { get; set; }
}
