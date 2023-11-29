using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITENSNOTA")]
public class ITENSNOTA
{
	[StringLength(14)]
	public string ITE_MATERIAL { get; set; }

	[StringLength(1)]
	public string ITE_TIPO { get; set; }

	public double? ITE_QUANTIDADE { get; set; }

	public double? ITE_UNITARIO { get; set; }

	public double? ITE_IPI { get; set; }

	[StringLength(6)]
	public string ITE_PEDIDO { get; set; }

	public int? ITE_SEPARACAO { get; set; }

	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short ITE_ITEM { get; set; }

	public double? ITE_GERENCIAL { get; set; }

	[StringLength(2)]
	public string ITE_CST_ICMS { get; set; }

	public byte? ITE_MODALIDADE_ICMS { get; set; }

	public double? ITE_BC_ICMS { get; set; }

	public double? ITE_ICMS_VALOR { get; set; }

	public double? ITE_REDUCAO_ICMS { get; set; }

	public byte? ITE_MODALIDADE_ICMS_ST { get; set; }

	public double? ITE_MARGEM_ICMS_ST { get; set; }

	public double? ITE_REDUCAO_ICMS_ST { get; set; }

	public double? ITE_BC_ICMS_ST { get; set; }

	public double? ITE_ICMS_ST { get; set; }

	public double? ITE_ICMS_ST_VALOR { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string ITE_DOC { get; set; }

	public double? ITE_ICMS_ALIQUOTA { get; set; }

	public double? ITE_ICMS_CREDITO_VALOR { get; set; }

	public double? ITE_FRETE_VALOR { get; set; }

	public short? ITE_SIMPLES_TRIBUTACAO { get; set; }

	public double? ITE_SIMPLES_ALIQUOTA_ICMS { get; set; }

	public double? ITE_BC_ICMS_ST_RETIDO { get; set; }

	public double? ITE_VALOR_ICMS_ST_RETIDO { get; set; }

	public short? ITE_CFOP { get; set; }

	public double? ITE_AQUISICAO { get; set; }

	public double? ITE_CUSTO_GERENCIAL { get; set; }

	public double? ITE_VALOR_DESCONTO { get; set; }

	public double? ITE_VALOR_TRIBUTO { get; set; }

	public double? ITE_PARTILHA_FCP { get; set; }

	public double? ITE_PARTILHA_INTERNA_DESTINATARIO { get; set; }

	public double? ITE_PARTILHA_INTERESTADUAL { get; set; }

	public double? ITE_PARTILHA_PROVISORIA { get; set; }

	public double? ITE_PARTILHA_FCP_VALOR { get; set; }

	public double? ITE_PARTILHA_ICMS_DESTINO_VALOR { get; set; }

	public double? ITE_PARTILHA_ICMS_REMETENTE_VALOR { get; set; }

	public double? ITE_PARTILHA_DIFAL_VALOR { get; set; }

	public double? ITE_PESO_BRUTO { get; set; }

	public double? ITE_PESO_LIQUIDO { get; set; }

	public int? ITE_MATERIAL_PRODUCAO { get; set; }

	public double? ITE_OUTRAS_DESPESAS { get; set; }

	public byte? ITE_PIS_CST { get; set; }

	public double? ITE_PIS_ALIQUOTA { get; set; }

	public double? ITE_PIS_VALOR { get; set; }

	public byte? ITE_COFINS_CST { get; set; }

	public double? ITE_COFINS_ALIQUOTA { get; set; }

	public double? ITE_COFINS_VALOR { get; set; }

	public double? ITE_IPI_VALOR { get; set; }

	[StringLength(500)]
	public string ITE_INFORMACAO_ADICIONAL { get; set; }

	public double? ITE_PIS_BC { get; set; }

	public double? ITE_COFINS_BC { get; set; }

	public double? ITE_FCP_ALIQUOTA { get; set; }

	public double? ITE_FCP_BC { get; set; }

	public double? ITE_FCP_VALOR { get; set; }

	public byte? ITE_IPI_CST { get; set; }

	public double? ITE_ITEM_DESCONTO { get; set; }

	public double? ITE_FCP_ST_ALIQUOTA { get; set; }

	public double? ITE_FCP_ST_BC { get; set; }

	public double? ITE_FCP_ST_VALOR { get; set; }

	public short ITE_BENEFICIO_FISCAL { get; set; }

	public byte? ITE_DESONERACAO_MOTIVO { get; set; }

	public double? ITE_DESONERACAO_ALIQUOTA { get; set; }

	public double? ITE_DESONERACAO_BC { get; set; }

	public double? ITE_DESONERACAO_VALOR { get; set; }

	public double? ITE_ICMS_EFETIVO_MOTIVO { get; set; }

	public double? ITE_ICMS_EFETIVO_ALIQUOTA { get; set; }

	public double? ITE_ICMS_EFETIVO_BC { get; set; }

	public double? ITE_ICMS_EFETIVO_VALOR { get; set; }

	public byte ITE_IPI_DEVOLVIDO_CST { get; set; }

	public double ITE_IPI_DEVOLVIDO_BC { get; set; }

	public double ITE_IPI_DEVOLVIDO_ALIQUOTA { get; set; }

	public double ITE_IPI_DEVOLVIDO_VALOR { get; set; }

	[NotMapped]
	public string ExtensaoCaixaDOC { get; set; }

	[NotMapped]
	public short? ExtensaoCaixaItem { get; set; }

	[NotMapped]
	public bool? ExtensaoServico { get; set; }
}
