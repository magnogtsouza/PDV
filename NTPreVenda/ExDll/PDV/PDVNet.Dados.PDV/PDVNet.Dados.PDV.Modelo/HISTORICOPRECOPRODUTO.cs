using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("HISTORICOPRECOPRODUTO")]
public class HISTORICOPRECOPRODUTO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string HIS_PRODUTO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte HIS_TABELA { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte HIS_SEQ { get; set; }

	public byte? HIS_TIPO_PRECO { get; set; }

	public double? HIS_ANTIGO { get; set; }

	public double? HIS_NOVO { get; set; }

	public DateTime? HIS_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string HIS_MATRICULA { get; set; }
}
