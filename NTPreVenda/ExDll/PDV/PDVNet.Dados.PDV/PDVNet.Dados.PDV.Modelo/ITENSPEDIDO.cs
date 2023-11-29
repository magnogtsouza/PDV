using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITENSPEDIDO")]
public class ITENSPEDIDO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(6)]
	public string ITE_PEDIDO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string ITE_PRODUTO { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short ITE_FILIAL { get; set; }

	public double? ITE_PEDIDA { get; set; }

	public double? ITE_ENTREGUE { get; set; }

	public double? ITE_PRECO { get; set; }

	public DateTime? ITE_D_ENTRADA { get; set; }

	[StringLength(6)]
	public string ITE_PEDIDO_VENDA { get; set; }

	public DateTime? ITE_ATUALIZACAO { get; set; }

	[StringLength(16)]
	public string ITE_CODIGON { get; set; }

	public byte? ITE_STATUS_NOVO { get; set; }

	public double? ITE_QTD_SUGERIDA { get; set; }

	public double? ITE_LIQUIDO { get; set; }

	public double? ITE_DESCONTO { get; set; }

	public bool ITE_TIPO_DESCONTO { get; set; }
}
