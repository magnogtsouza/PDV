using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SINCRONIZACAOSIMPLIFICADA")]
public class SINCRONIZACAOSIMPLIFICADA
{
	[Key]
	[Column(Order = 0)]
	public short SIS_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte SIS_CAIXA { get; set; }

	[Key]
	[Column(Order = 2)]
	public short SIS_TABELA { get; set; }

	public bool? SIS_ATUALIZAR { get; set; }
}
