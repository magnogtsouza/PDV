using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class VENDAS
{
	[Required]
	[StringLength(14)]
	public string VEN_PRODUTO { get; set; }

	public double? VEN_VALOR { get; set; }

	public double? VEN_QUANTIDADE { get; set; }

	public bool? VEN_NATUREZA { get; set; }

	public double? VEN_PRECO_TABELA { get; set; }

	public short? VEN_FILIAL { get; set; }

	public double? VEN_AQUISICAO { get; set; }

	public double? VEN_GERENCIAL { get; set; }

	public byte? VEN_GUELTA { get; set; }

	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short VEN_ITEM { get; set; }

	public double? VEN_LIQUIDO { get; set; }

	public double? VEN_COMISSAO { get; set; }

	public double? VEN_V_GUELTA { get; set; }

	public DateTime? VEN_DATA { get; set; }

	public byte? VEN_GUELTA2 { get; set; }

	[StringLength(3)]
	public string VEN_SITUACAO { get; set; }

	public double? VEN_ICMS { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string VEN_DOC { get; set; }

	public bool? VEN_INATIVA { get; set; }

	public double? VEN_ACRESCIMO { get; set; }

	public double? VEN_DESCONTO { get; set; }

	[StringLength(8)]
	public string VEN_VENDEDOR { get; set; }

	[NotMapped]
	public double? RES_PESO { get; set; }

	[NotMapped]
	public double? RES_ALTURA { get; set; }

	[NotMapped]
	public double? RES_LARGURA { get; set; }

	[NotMapped]
	public double? RES_PROFUNDIDADE { get; set; }

	[NotMapped]
	public int? ITE_CFOP { get; set; }

	[NotMapped]
	public string ExtensaoReferencia { get; set; }

	[NotMapped]
	public string ExtensaoColecao { get; set; }

	[NotMapped]
	public bool ExtensaoTributado { get; set; }

	[NotMapped]
	public string ExtensaoSituacao { get; set; }

	[NotMapped]
	public string ExtensaoNCM { get; set; }

	[NotMapped]
	public short ExtensaoTipoProduto { get; set; }

	[NotMapped]
	public bool ExtensaoEServico { get; set; }
}
