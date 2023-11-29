using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ECF_VENDAS
{
	[Required]
	[StringLength(14)]
	public string VEN_PRODUTO { get; set; }

	public double? VEN_VALOR { get; set; }

	public double? VEN_QUANTIDADE { get; set; }

	public double? VEN_PRECO_TABELA { get; set; }

	public short? VEN_FILIAL { get; set; }

	public double? VEN_AQUISICAO { get; set; }

	public double? VEN_GERENCIAL { get; set; }

	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int VEN_ITEM { get; set; }

	public double? VEN_LIQUIDO { get; set; }

	public DateTime? VEN_DATA { get; set; }

	[StringLength(3)]
	public string VEN_SITUACAO { get; set; }

	public double? VEN_ICMS { get; set; }

	public bool? VEN_INATIVO { get; set; }

	public int? VEN_ASSINA { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string VEN_DOC { get; set; }

	[StringLength(2)]
	public string VEN_TOTALIZADOR { get; set; }

	public bool? VEN_NATUREZA { get; set; }

	public double? VEN_ACRESCIMO { get; set; }

	public double? VEN_DESCONTO { get; set; }
}
