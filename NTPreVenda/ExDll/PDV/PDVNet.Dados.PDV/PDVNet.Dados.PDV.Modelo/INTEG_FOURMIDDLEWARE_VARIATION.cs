using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_FOURMIDDLEWARE_VARIATION_STATUS
{
	[Key]
	[Column(Order = 0)]
	public byte VAS_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string VAS_PDV_CODIGO { get; set; }

	public bool? VAS_STATUS { get; set; }

	public DateTime? VAS_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string VAR_SKU { get; set; }

	[NotMapped]
	public string REF_REFERENCIA { get; set; }

	[NotMapped]
	public string REF_REFERENCIA_FORNECEDOR { get; set; }

	[NotMapped]
	public bool? REF_SITE { get; set; }

	[NotMapped]
	public byte? RES_EXIBIR { get; set; }

	[NotMapped]
	public bool? REF_INATIVO2 { get; set; }

	[NotMapped]
	public byte? MAT_SITE { get; set; }

	[NotMapped]
	public bool? MAT_INATIVO { get; set; }
}
public class INTEG_FOURMIDDLEWARE_VARIATION
{
	[Key]
	[Column(Order = 0)]
	public byte VAR_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string VAR_PDV_CODIGO { get; set; }

	[StringLength(30)]
	public string VAR_SKU { get; set; }

	[NotMapped]
	public string ExtensaoReferencia { get; set; }

	[NotMapped]
	public string ExtensaoReferenciaFornecedor { get; set; }
}
public class INTEG_FOURMIDDLEWARE_VARIATION_PRICE
{
	[Key]
	[Column(Order = 0)]
	public byte VAP_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string VAP_PDV_CODIGO { get; set; }

	public double? VAP_LIST_PRICE { get; set; }

	public double? VAP_SELL_PRICE { get; set; }

	public DateTime? VAP_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string VAR_SKU { get; set; }

	[NotMapped]
	public string REF_REFERENCIA { get; set; }

	[NotMapped]
	public string REF_REFERENCIA_FORNECEDOR { get; set; }
}
public class INTEG_FOURMIDDLEWARE_VARIATION_STOCK
{
	[Key]
	[Column(Order = 0)]
	public byte VAS_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string VAS_PDV_CODIGO { get; set; }

	public int? VAS_STOCK { get; set; }

	public DateTime? VAS_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string VAR_SKU { get; set; }

	[NotMapped]
	public string REF_REFERENCIA { get; set; }

	[NotMapped]
	public string REF_REFERENCIA_FORNECEDOR { get; set; }
}
