using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ITICAIXA
{
	[Key]
	[Column(Order = 0)]
	public short ITC_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte ITC_CAIXA { get; set; }

	public bool? ITC_INATIVO { get; set; }

	public DateTime? ITC_ATUALIZACAO { get; set; }
}
