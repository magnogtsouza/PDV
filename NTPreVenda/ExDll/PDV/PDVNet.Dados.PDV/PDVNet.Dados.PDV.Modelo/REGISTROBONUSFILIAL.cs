using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class REGISTROBONUSFILIAL
{
	[Key]
	[Column(Order = 0)]
	public short RBF_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short RBF_FILIAL { get; set; }
}
