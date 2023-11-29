using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITENSCONSIGNACAO")]
public class ITENSCONSIGNACAO
{
	[StringLength(8)]
	public string ITC_CODIGO { get; set; }

	[StringLength(14)]
	public string ITC_PRODUTO { get; set; }

	public DateTime? ITC_DATA { get; set; }

	public double? ITC_AQUISICAO { get; set; }

	public double? ITC_GERENCIAL { get; set; }

	public double? ITC_PRECO_VENDIDO { get; set; }

	public double? ITC_PRECO_TABELA { get; set; }

	public double? ITC_CONSIGNADA { get; set; }

	public double? ITC_DEVOLVIDA { get; set; }

	public double? ITC_VENDIDA { get; set; }

	[StringLength(6)]
	public string ITC_BOLETA { get; set; }

	public DateTime? ITC_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string ITC_MATRICULA { get; set; }

	public double? ITC_COMISSAO { get; set; }

	public double? ITC_GUELTA { get; set; }

	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string ITC_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short ITC_SEQ { get; set; }
}
