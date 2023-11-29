using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class NOTA_FISCAL
{
	public short? NOT_FILIAL { get; set; }

	[Required]
	[StringLength(9)]
	public string NOT_NUMERO { get; set; }

	public byte? NOT_TIPO { get; set; }

	[StringLength(6)]
	public string NOT_PEDIDO { get; set; }

	public DateTime? NOT_EMISSAO { get; set; }

	public short? NOT_NATUREZA { get; set; }

	[StringLength(5)]
	public string NOT_MARCA { get; set; }

	[StringLength(30)]
	public string NOT_ESPECIE { get; set; }

	[StringLength(1)]
	public string NOT_STATUS { get; set; }

	public short? NOT_TRANSPORTADORA { get; set; }

	public short? NOT_CONDICAO { get; set; }

	public double? NOT_QUANTIDADE { get; set; }

	public double? NOT_VALOR_NOTA { get; set; }

	public double? NOT_VALOR_MERCADORIA { get; set; }

	public double? NOT_VALOR_ICMS { get; set; }

	public double? NOT_VALOR_IPI { get; set; }

	public double? NOT_VALOR_ISS { get; set; }

	public DateTime? NOT_CADASTRO { get; set; }

	public double? NOT_PESO_BRUTO { get; set; }

	public double? NOT_PESO_LIQUIDO { get; set; }

	[Column(TypeName = "ntext")]
	public string NOT_OBS { get; set; }

	public double? NOT_SEGURO { get; set; }

	public double? NOT_FRETE { get; set; }

	public double? NOT_OUTROS { get; set; }

	public double? NOT_VALOR_BASE { get; set; }

	public byte? NOT_T_FRETE { get; set; }

	[StringLength(15)]
	public string NOT_VIA { get; set; }

	public double? NOT_DESCONTO { get; set; }

	[StringLength(1)]
	public string NOT_TIPO_DESCONTO { get; set; }

	[StringLength(1)]
	public string NOT_ESTOQUE { get; set; }

	[StringLength(1)]
	public string NOT_AGRUPAR { get; set; }

	[StringLength(1)]
	public string NOT_GERAR_DUPLICATA { get; set; }

	public byte? NOT_TIPO_PEDIDO { get; set; }

	public double? NOT_ISENTO { get; set; }

	[StringLength(1)]
	public string NOT_TIPO_PRODUTO { get; set; }

	[StringLength(16)]
	public string NOT_CODIGON { get; set; }

	public double? NOT_GERENCIAL { get; set; }

	public byte? NOT_TABELA { get; set; }

	public double? NOT_ICMS_BC_ST { get; set; }

	public double? NOT_ICMS_ST { get; set; }

	public double? NOT_PIS { get; set; }

	public double? NOT_COFINS { get; set; }

	[StringLength(50)]
	public string NOT_NFE_CHAVE { get; set; }

	public int? NOT_NFE_LOTE { get; set; }

	[StringLength(15)]
	public string NOT_NFE_PROTOCOLO { get; set; }

	public byte? NOT_NFE_STATUS { get; set; }

	public DateTime? NOT_NFE_DATA_PROTOCOLO { get; set; }

	public short? NOT_SERIE { get; set; }

	[Key]
	[StringLength(20)]
	public string NOT_DOC { get; set; }

	public double? NOT_ICMS { get; set; }

	public short? NOT_PARCELAS { get; set; }

	public short? NOT_ITENS { get; set; }

	[StringLength(20)]
	public string NOT_CAIXA_DOC { get; set; }

	public byte? NOT_TIPO_OPERACAO { get; set; }

	public double? NOT_VALOR_IMPORTACAO { get; set; }

	public byte? NOT_REGIME { get; set; }

	public byte? NOT_PIS_TRIBUTACAO { get; set; }

	public double? NOT_PIS_ALIQUOTA { get; set; }

	public byte? NOT_COFINS_TRIBUTACAO { get; set; }

	public double? NOT_COFINS_ALIQUOTA { get; set; }

	public short? NOT_SIMPLES_TRIBUTACAO { get; set; }

	public double? NOT_SIMPLES_ALIQUOTA_ICMS { get; set; }

	public byte? NOT_ENDERECO_ENTREGA { get; set; }

	public byte? NOT_TIPO_CADASTRO { get; set; }

	public short? NOT_REPRESENTANTE { get; set; }

	public int? NOT_SEPARACAO { get; set; }

	[StringLength(16)]
	public string NOT_CHAVE { get; set; }

	[StringLength(40)]
	public string NOT_MD5 { get; set; }

	public byte? NOT_NFE_AMBIENTE { get; set; }

	public byte? NOT_CONTINGENCIA { get; set; }

	public byte? NOT_TRANSFERENCIA_ICMS { get; set; }

	[StringLength(8)]
	public string NOT_MATRICULA { get; set; }

	public byte? NOT_DANFE_AGRUPADO { get; set; }

	public byte? NOT_DESCONTO_INCONDICIONAL { get; set; }

	public byte? NOT_FINALIDADE { get; set; }

	public double? NOT_VALOR_TRIBUTO { get; set; }

	[StringLength(8)]
	public string NOT_PLACA { get; set; }

	public byte? NOT_PLACA_UF { get; set; }

	public byte? NOT_TIPO_NF { get; set; }

	public bool? NOT_CONSUMIDOR_FINAL { get; set; }

	public DateTime? NOT_SAIDA { get; set; }

	[StringLength(60)]
	public string NOT_NFE_PEDIDO { get; set; }

	public bool? NOT_ATUALIZAR_ESTOQUE { get; set; }

	public double? NOT_SERVICO_VALOR { get; set; }

	public double? NOT_ISS_BC { get; set; }

	public double? NOT_ISS_VALOR { get; set; }

	public double? NOT_FCP { get; set; }

	public double? NOT_VALOR_FCP { get; set; }

	public double? NOT_VALOR_FCP_ST { get; set; }

	public double? NOT_VALOR_DESONERACAO { get; set; }

	public double? NOT_VALOR_IPI_DEVOLVIDO { get; set; }

	public byte? NOT_INDICADOR_PRESENCA { get; set; }

	public byte? NOT_INDICADOR_INTERMEDIADOR { get; set; }

	public double? NOT_VALOR_FCP_ST_RETIDO { get; set; }

	public byte? NOT_MARKETPLACE { get; set; }

	public DateTime? NOT_ATUALIZACAO { get; set; }

	public short? NOT_LOTE { get; set; }

	public bool? NOT_BLOQUEADO { get; set; }

	[NotMapped]
	public string ExtensaoCodigoRastreio { get; set; }

	[NotMapped]
	public bool? ExtensaoClienteExterior { get; set; }

	public virtual ICollection<ITENSNOTA> ITENSNOTA { get; set; }

	public virtual ICollection<DUPLICATAS> DUPLICATAS { get; set; }

	[NotMapped]
	public string TRA_CGC { get; set; }

	[NotMapped]
	public string NFX_XML { get; set; }

	[NotMapped]
	public double? NFX_VALOR { get; set; }

	[NotMapped]
	public virtual string FIL_CGC { get; set; }

	[NotMapped]
	public byte? NFX_TIPO_NF { get; set; }

	[NotMapped]
	public virtual CAIXA CAIXA { get; set; }

	[NotMapped]
	public virtual CLIENTES CLIENTES { get; set; }

	[NotMapped]
	public virtual FILIAL FILIAL { get; set; }

	[NotMapped]
	public virtual INTEGRACAOPEDIDO INTEGRACAOPEDIDO { get; set; }
}
