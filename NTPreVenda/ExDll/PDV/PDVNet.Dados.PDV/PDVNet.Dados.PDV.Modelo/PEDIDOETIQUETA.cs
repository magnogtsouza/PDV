using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("PEDIDOETIQUETA")]
public class PEDIDOETIQUETA
{
	[Key]
	[Column(Order = 0)]
	[StringLength(6)]
	public string PED_PEDIDO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int PED_FILIAL { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(14)]
	public string PED_PRODUTO { get; set; }

	public DateTime? PED_DATA { get; set; }

	[StringLength(8)]
	public string PED_MATRICULA { get; set; }

	public short? PED_QTD { get; set; }

	public byte? PED_STATUS { get; set; }

	public DateTime? PED_D_EMISSAO { get; set; }
}
