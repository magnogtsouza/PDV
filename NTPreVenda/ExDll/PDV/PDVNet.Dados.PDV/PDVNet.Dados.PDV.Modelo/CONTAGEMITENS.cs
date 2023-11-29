using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CONTAGEMITENS
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int ITC_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public DateTime ITC_CADASTRO { get; set; }

	[StringLength(14)]
	public string ITC_PRODUTO { get; set; }

	public double? ITC_QTD { get; set; }

	public byte? ITC_INATIVO { get; set; }
}
