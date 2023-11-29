using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CONFERENCIASEPARACAOITENS
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short COI_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public DateTime COI_CADASTRO { get; set; }

	[StringLength(14)]
	public string COI_PRODUTO { get; set; }

	public double? COI_QTD { get; set; }

	public bool? COI_INATIVO { get; set; }
}
