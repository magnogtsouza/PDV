using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITENSSEPARAVENDA")]
public class ITENSSEPARAVENDA
{
	[StringLength(6)]
	public string ISV_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string ISV_DOC { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int ISV_ITEM { get; set; }

	[StringLength(14)]
	public string ISV_PRODUTO { get; set; }

	public double? ISV_QTD { get; set; }

	public byte? ISV_FATURADO { get; set; }

	public bool? ISV_INATIVO { get; set; }

	public DateTime? ISV_CADASTRO { get; set; }

	public DateTime? ISV_ATUALIZACAO { get; set; }

	public DateTime? ISV_FATURAMENTO { get; set; }

	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string ISV_SEPARACAO_DOC { get; set; }

	public DateTime? ISV_DATA_ENTREGA { get; set; }

	public short? ISV_STATUS_CONFERENCIA { get; set; }
}
