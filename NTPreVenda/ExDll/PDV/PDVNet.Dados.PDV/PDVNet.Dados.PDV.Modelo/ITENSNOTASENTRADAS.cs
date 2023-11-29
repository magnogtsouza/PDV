using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ITENSNOTASENTRADAS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string ITE_PRODUTO { get; set; }

	public double? ITE_VALOR { get; set; }

	public double? ITE_QUANTIDADE { get; set; }

	public double? ITE_IPI { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(6)]
	public string ITE_PEDIDO { get; set; }

	public double? ITE_DEVOLVIDA { get; set; }

	public double? ITE_ENTREGUE { get; set; }

	public double? ITE_GERENCIAL { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(20)]
	public string ITE_DOC { get; set; }

	[StringLength(3)]
	public string ITE_CST { get; set; }

	public double? ITE_CONTABIL { get; set; }

	public double? ITE_ICMS { get; set; }

	public double? ITE_ICMS_BASE { get; set; }

	public double? ITE_ICMS_VALOR { get; set; }

	public double? ITE_LIQUIDO { get; set; }

	public double? ITE_DESCONTO { get; set; }

	public short? ITE_CFOP { get; set; }

	public double? ITE_AQUISICAO { get; set; }

	public double? ITE_CUSTO_GERENCIAL { get; set; }

	public double? ITE_BC_ICMS_ST { get; set; }

	public double? ITE_ICMS_ST { get; set; }
}
