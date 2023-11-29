using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class DISTRIBUICAOCITENS
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int DCI_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public DateTime DCI_CADASTRO { get; set; }

	[StringLength(6)]
	public string DCI_ROMANEIO { get; set; }

	public short? DCI_FILIAL { get; set; }

	[StringLength(14)]
	public string DCI_PRODUTO { get; set; }

	public double? DCI_QTD { get; set; }

	public bool? DCI_INATIVO { get; set; }
}
