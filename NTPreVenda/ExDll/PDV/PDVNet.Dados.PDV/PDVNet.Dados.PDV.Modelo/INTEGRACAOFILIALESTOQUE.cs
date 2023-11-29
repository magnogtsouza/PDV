using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOFILIALESTOQUE
{
	[Key]
	[Column(Order = 0)]
	public byte IFE_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short? IFE_FILIAL { get; set; }

	public bool? IFE_USA_ESTOQUE_MINIMO { get; set; }
}
