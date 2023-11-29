using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CLIENTECHEQUE
{
	[Key]
	[Column(Order = 0)]
	public short CHE_BANCO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(4)]
	public string CHE_AGENCIA { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(6)]
	public string CHE_CHEQUE { get; set; }

	[Key]
	[Column(Order = 3)]
	public DateTime? CHE_VENCIMENTO { get; set; }

	public double? CHE_VALOR { get; set; }

	[StringLength(16)]
	public string CHE_CODIGON { get; set; }
}
