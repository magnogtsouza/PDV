using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("USUARIOCOLUNA")]
public class USUARIOCOLUNA
{
	[Key]
	[Column(Order = 0)]
	[StringLength(6)]
	public string USC_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte USC_CAMPO { get; set; }

	public short? USC_LARGURA { get; set; }

	public byte? USC_ORDEM { get; set; }

	public bool? USC_INATIVO { get; set; }

	public byte? USC_TABELA { get; set; }
}
