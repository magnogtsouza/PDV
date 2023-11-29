using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("HISTORICOPRECO")]
public class HISTORICOPRECO
{
	[Key]
	[Column(Order = 0)]
	public short HIS_COLECAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(8)]
	public string HIS_REFERENCIA { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte HIS_TIPO_PRECO { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte HIS_SEQ { get; set; }

	public DateTime? HIS_DATA { get; set; }

	public double? HIS_ANTIGO { get; set; }

	public double? HIS_NOVO { get; set; }

	[StringLength(8)]
	public string HIS_USUARIO { get; set; }

	public byte? HIS_REDE { get; set; }
}
