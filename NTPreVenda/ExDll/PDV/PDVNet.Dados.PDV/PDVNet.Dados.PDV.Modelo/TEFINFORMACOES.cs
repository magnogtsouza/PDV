using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class TEFINFORMACOES
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string TEI_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte? TEI_SEQ { get; set; }

	[StringLength(9)]
	public string TEI_COO { get; set; }

	[StringLength(20)]
	public string TEI_REDE { get; set; }

	[StringLength(20)]
	public string TEI_NSU { get; set; }

	public double? TEI_VALOR_COMPRA { get; set; }

	public double? TEI_VALOR_PAGAMENTO { get; set; }

	[Column(TypeName = "ntext")]
	public string TEI_VIA_UNICA { get; set; }

	[Column(TypeName = "ntext")]
	public string TEI_VIA_CLIENTE { get; set; }

	[Column(TypeName = "ntext")]
	public string TEI_VIA_ESTABELECIMENTO { get; set; }

	public DateTime? TEI_ATUALIZACAO { get; set; }

	[Column(TypeName = "ntext")]
	public string TEI_VIA_CANCELAMENTO { get; set; }

	[StringLength(6)]
	public string TEI_AUTORIZACAO { get; set; }
}
