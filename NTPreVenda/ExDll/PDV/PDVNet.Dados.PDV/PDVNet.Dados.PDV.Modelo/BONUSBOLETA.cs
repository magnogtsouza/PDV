using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("BONUSBOLETA")]
public class BONUSBOLETA
{
	[Key]
	[Column(Order = 0)]
	public short BOB_CODIGO { get; set; }

	public double? BOB_SALDO_INICIAL { get; set; }

	public bool? BOB_EXCLUIDO { get; set; }

	public DateTime? BOB_D_EXCLUIDO { get; set; }

	[StringLength(20)]
	public string BOB_BONUS { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string BOB_DOC { get; set; }
}
