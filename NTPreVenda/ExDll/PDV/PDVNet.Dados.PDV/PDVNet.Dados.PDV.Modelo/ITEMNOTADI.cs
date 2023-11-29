using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITEMNOTADI")]
public class ITEMNOTADI
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string IND_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public short IND_SEQ_ITEM { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte? IND_SEQ { get; set; }

	[StringLength(10)]
	public string IND_NUMERO_DI { get; set; }

	public DateTime? IND_DATA_REGISTRO { get; set; }

	[StringLength(60)]
	public string IND_LOCAL_DESEMBARACO { get; set; }

	[StringLength(2)]
	public string IND_UF_DESEMBARACO { get; set; }

	public DateTime? IND_DATA_DESEMBARACO { get; set; }

	[StringLength(60)]
	public string IND_CODIGO_EXPORTADOR { get; set; }

	public byte? IND_VIA_TRANSPORTE { get; set; }

	public double? IND_VALOR_AFRMM { get; set; }

	public byte? IND_INTERMEDIO { get; set; }
}
