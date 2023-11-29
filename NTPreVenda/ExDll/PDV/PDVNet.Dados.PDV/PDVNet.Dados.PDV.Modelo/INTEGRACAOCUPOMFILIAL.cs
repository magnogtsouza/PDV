using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOCUPOMFILIAL
{
	[Key]
	[Column(Order = 0)]
	public byte ICF_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(50)]
	public string ICF_CUPOM { get; set; }

	public short? ICF_FILIAL_PDV { get; set; }
}
