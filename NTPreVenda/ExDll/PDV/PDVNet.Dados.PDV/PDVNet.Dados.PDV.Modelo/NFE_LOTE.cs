using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class NFE_LOTE
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int NFL_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int NFL_FILIAL { get; set; }

	public DateTime? NFL_DATA_ENVIO { get; set; }

	[StringLength(15)]
	public string NFL_RECIBO { get; set; }

	public byte? NFL_STATUS { get; set; }

	public byte NFL_TIPO_NF { get; set; }
}
