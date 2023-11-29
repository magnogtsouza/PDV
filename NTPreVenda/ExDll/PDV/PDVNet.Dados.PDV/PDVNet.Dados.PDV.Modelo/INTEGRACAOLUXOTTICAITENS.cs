using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOLUXOTTICAITENS
{
	[Key]
	[Column(Order = 0)]
	public short ILI_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short ILI_FILIAL { get; set; }

	[Key]
	[Column(Order = 2)]
	public short ILI_SEQ { get; set; }

	public byte? ILI_OPERACAO { get; set; }

	public DateTime? ILI_DATA_TRANSACAO { get; set; }

	[StringLength(13)]
	public string ILI_PRODUTO { get; set; }

	public double? ILI_QUANTIDADE { get; set; }

	public double? ILI_PRECO_VENDA { get; set; }
}
