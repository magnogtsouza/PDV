using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CONDICOESPRAZOS
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int COP_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte COP_PARCELA { get; set; }

	public int? COP_PRAZO { get; set; }
}
