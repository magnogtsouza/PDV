using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("PRODUTONEGATIVO")]
public class PRODUTONEGATIVO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PRN_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string PRN_PRODUTO { get; set; }

	[Key]
	[Column(Order = 2)]
	public DateTime PRN_DATA { get; set; }

	public byte? PRN_TIPO { get; set; }

	public byte? PRN_TELA { get; set; }

	public double? PRN_SALDO { get; set; }

	public double? PRN_QTD { get; set; }

	[StringLength(8)]
	public string PRN_USUARIO { get; set; }
}
