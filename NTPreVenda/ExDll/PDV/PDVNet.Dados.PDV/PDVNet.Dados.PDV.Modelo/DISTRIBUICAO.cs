using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DISTRIBUICAO")]
public class DISTRIBUICAO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(6)]
	public string DIS_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short DIS_FILIAL { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(14)]
	public string DIS_PRODUTO { get; set; }

	public double? DIS_QUANTIDADE { get; set; }

	public double? DIS_RECEBIDA { get; set; }

	[StringLength(1)]
	public string DIS_RAZAO { get; set; }

	public DateTime? DIS_SEPARACAO { get; set; }

	public double? DIS_VENDA { get; set; }

	public double? DIS_CUSTO { get; set; }

	public double? DIS_CUSTO_GERENCIAL { get; set; }

	public bool? DIS_INATIVO { get; set; }

	public double? DIS_FATOR_CONVERSAO { get; set; }
}
