using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class REGISTROBONUSPLANOPAGAMENTO
{
	[Key]
	public short RBP_CODIGO { get; set; }

	[Key]
	public short RBP_PLANO_PAGAMENTO { get; set; }

	public double RBP_PERCENTUAL { get; set; }

	public bool RBP_INATIVO { get; set; }
}
