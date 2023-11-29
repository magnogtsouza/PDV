using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MOVIMENTACAOESTOQUE")]
public class MOVIMENTACAOESTOQUE
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string MOE_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string MOE_PRODUTO { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short MOE_SEQ { get; set; }

	public byte? MOE_TIPO_DOCUMENTO { get; set; }

	public short? MOE_FILIAL { get; set; }

	public DateTime? MOE_DATA { get; set; }

	public double? MOE_QUANTIDADE { get; set; }

	public double? MOE_PRECO { get; set; }

	public double? MOE_AQUISICAO { get; set; }

	public double? MOE_GERENCIAL { get; set; }

	public bool? MOE_INATIVO { get; set; }
}
