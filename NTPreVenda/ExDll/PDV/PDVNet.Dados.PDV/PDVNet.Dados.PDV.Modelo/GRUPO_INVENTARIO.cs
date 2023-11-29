using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class GRUPO_INVENTARIO
{
	[Key]
	[Column(Order = 0)]
	public short INVG_INVENTARIO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(8)]
	public string INVG_GRUPO { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int INVG_FILIAL { get; set; }
}
