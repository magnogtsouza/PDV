using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("RESUMOFORMA")]
public class RESUMOFORMA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short RES_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte RES_CAIXA { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte RES_IMPRESSORA { get; set; }

	[Key]
	[Column(Order = 3)]
	[StringLength(6)]
	public string RES_COO { get; set; }

	public DateTime? RES_DATA { get; set; }

	[Key]
	[Column(Order = 4)]
	[StringLength(30)]
	public string RES_FORMA { get; set; }

	public byte? RES_FISCAL { get; set; }

	public double? RES_VALOR { get; set; }

	public int? RES_ASSINA { get; set; }

	[StringLength(20)]
	public string RES_SERIAL { get; set; }
}
