using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITENSPEDIDOVENDA")]
public class ITENSPEDIDOVENDA
{
	public string ExtensaoCorDescricao { get; set; }

	public string ExtensaoTamanhoDescricao { get; set; }

	public string ReferenciaDescricao { get; set; }

	public string Referencia { get; set; }

	public string CorDescricao { get; set; }

	public short CorCodigo { get; set; }

	public string TamanhoDescricao { get; set; }

	public short TamanhoCodigo { get; set; }

	public string DescricaoKIT { get; set; }

	public int KitCodigo { get; set; }

	[Key]
	[Column(Order = 0)]
	[StringLength(6)]
	public string ITE_PEDIDO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(16)]
	public string ITE_CODIGON { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(14)]
	public string ITE_PRODUTO { get; set; }

	public double? ITE_PEDIDA { get; set; }

	public double? ITE_ENTREGUE { get; set; }

	public double? ITE_PRECO { get; set; }

	public DateTime? ITE_D_ENTRADA { get; set; }

	public DateTime? ITE_ENTREGA { get; set; }

	public DateTime? ITE_ATUALIZACAO { get; set; }

	public double? ITE_SEPARADO { get; set; }

	[StringLength(6)]
	public string ITE_PEDIDO_COMPRA { get; set; }

	public double? ITE_VENDA { get; set; }

	public short? ITE_FILIAL { get; set; }

	[StringLength(3)]
	public string ITE_MOTIVO { get; set; }

	public double? ITE_DESCONTO { get; set; }

	public double? ITE_QUANTIDADE_SUGERIDA { get; set; }

	public bool ITE_FINALIZADO { get; set; }

	public byte? ITE_STATUS_NOVO { get; set; }

	public byte? ITE_STATUS_CONFERENCIA { get; set; }

	public int? ITE_KIT_LOTE { get; set; }

	public short? ITE_SEQ { get; set; }

	public int? ITE_SEQ_LOTE { get; set; }

	public byte? ITE_KIT_TIPO { get; set; }

	public double? ITE_AQUISICAO { get; set; }

	public double? ITE_GERENCIAL { get; set; }
}
