using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class DIVERGENCIAS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(6)]
	public string DIV_INVENTARIO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string DIV_PRODUTO { get; set; }

	public double? DIV_INVENTARIADA { get; set; }

	public double? DIV_SALDO_ANTIGO { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int DIV_FILIAL { get; set; }
}
