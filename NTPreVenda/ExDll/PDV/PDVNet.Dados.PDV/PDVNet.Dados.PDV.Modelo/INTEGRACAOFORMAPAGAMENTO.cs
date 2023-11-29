using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOFORMAPAGAMENTO
{
	[Key]
	[Column(Order = 0)]
	public byte IFP_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(40)]
	public string IFP_PLATAFORMA_CODIGO { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(40)]
	public string IFP_PLATAFORMA_CARTAO { get; set; }

	public byte? IFP_PDV_FORMA { get; set; }

	public byte? IFP_PDV_CARTAO { get; set; }

	public short? IFP_PDV_PLANO_PAGAMENTO { get; set; }

	public Guid? IFP_PDV_PIX { get; set; }
}
