using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REFERENCIASITE")]
public class REFERENCIASITE
{
	[Key]
	[Column(Order = 0)]
	public short RES_COLECAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(12)]
	public string RES_REFERENCIA { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte RES_REDE { get; set; }

	[StringLength(255)]
	public string RES_NOME { get; set; }

	[Column(TypeName = "ntext")]
	public string RES_DESCRICAO { get; set; }

	[StringLength(255)]
	public string RES_PALAVRAS { get; set; }

	public short? RES_CATEGORIA { get; set; }

	public byte? RES_EXIBIR { get; set; }

	public double? RES_PESO { get; set; }

	public double? RES_ALTURA { get; set; }

	public double? RES_LARGURA { get; set; }

	public double? RES_PROFUNDIDADE { get; set; }

	public byte? RES_MODALIDADE_FRETE { get; set; }

	[StringLength(255)]
	public string RES_DESCRICAO_CURTA { get; set; }
}
