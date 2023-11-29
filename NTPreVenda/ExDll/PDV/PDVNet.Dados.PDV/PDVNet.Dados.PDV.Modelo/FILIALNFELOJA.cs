using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALNFELOJA")]
public class FILIALNFELOJA
{
	[Key]
	[Column(Order = 0)]
	public short FNL_FILIAL { get; set; }

	public byte? FNL_TROCA_TIPO_NOTA { get; set; }

	public short? FNL_TROCA_CFOP { get; set; }

	public byte? FNL_VENDA_TIPO_NOTA { get; set; }

	public short? FNL_VENDA_CFOP { get; set; }

	public byte? FNL_VENDA_TIPO_NOTA_SUBS { get; set; }

	public short? FNL_VENDA_CFOP_SUBS { get; set; }

	[StringLength(6)]
	public string FNL_ID_TOKEN { get; set; }

	[StringLength(36)]
	public string FNL_CSC { get; set; }

	public short? FNL_CSOSN_SUBS { get; set; }

	public double? FNL_ALIQUOTA_ICMS_SUBS { get; set; }

	public byte? FNL_TRANSFERENCIA_TIPO_NOTA { get; set; }

	public double? FNL_ALIQUOTA_FCP { get; set; }

	public short? FNL_CSOSN_ISENTOS { get; set; }

	public DateTime? FNL_ATUALIZACAO { get; set; }

	public short? FNL_TROCA_SERIE { get; set; }

	public short? FNL_TRANSFERENCIA_SERIE { get; set; }

	public short? FNL_PEDIDO_ENTREGA_SERIE { get; set; }

	public byte? FNL_REGIME { get; set; }

	public byte? FNL_PIS_TRIBUTACAO { get; set; }

	public double? FNL_PIS_ALIQUOTA { get; set; }

	public byte? FNL_COFINS_TRIBUTACAO { get; set; }

	public double? FNL_COFINS_ALIQUOTA { get; set; }

	public byte? FNL_ICMS_TRIBUTACAO { get; set; }

	public short? FNL_SIMPLES_TRIBUTACAO { get; set; }

	public double? FNL_SIMPLES_ALIQUOTA_ICMS { get; set; }

	public short? FNL_SERIE_RETAGUARDA { get; set; }

	public bool? FNL_LEI_DA_MODA { get; set; }

	public int? FNL_CNAE { get; set; }
}
