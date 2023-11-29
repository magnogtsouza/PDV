using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using PDVNet.Dados.PDV.Modelo.ModelosGerais;
//using PDVNet.Util;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAIXA")]
public class CAIXA
{
	public short? CAI_FILIAL { get; set; }

	public DateTime? CAI_DATA { get; set; }

	public double? CAI_VALOR { get; set; }

	public double? CAI_DINHEIRO { get; set; }

	public double? CAI_VALE { get; set; }

	public double? CAI_CHEQUE { get; set; }

	public double? CAI_CARTAO { get; set; }

	public double? CAI_OUTROS { get; set; }

	public double? CAI_PRE { get; set; }

	[StringLength(8)]
	public string CAI_USUARIO { get; set; }

	[StringLength(6)]
	public string CAI_NOTA { get; set; }

	public double? CAI_DEPOSITO { get; set; }

	public double? CAI_DESCONTO { get; set; }

	[StringLength(1)]
	public string CAI_RETIRADA { get; set; }

	public double? CAI_DOLAR { get; set; }

	public double? CAI_CAMBIO { get; set; }

	public double? CAI_TROCO { get; set; }

	public double? CAI_VENDIDAS { get; set; }

	public double? CAI_TROCADAS { get; set; }

	[StringLength(8)]
	public string CAI_DECORADOR { get; set; }

	[StringLength(18)]
	public string CAI_CPF { get; set; }

	public double? CAI_VALE_SAIDA { get; set; }

	public double? CAI_DEBITO { get; set; }

	public double? CAI_CREDITO_PARCELADO { get; set; }

	public double? CAI_EXCESSO { get; set; }

	[StringLength(8)]
	public string CAI_MATRICULA { get; set; }

	public byte? CAI_TABELA { get; set; }

	public byte? CAI_TURNO { get; set; }

	public byte? CAI_CAIXA { get; set; }

	public byte? CAI_TIPO_DESCONTO { get; set; }

	public double? CAI_BONUS { get; set; }

	[StringLength(16)]
	public string CAI_CODIGON { get; set; }

	public double? CAI_FRETE { get; set; }

	public double? CAI_VENDA_VALE { get; set; }

	public double? CAI_CREDIARIO { get; set; }

	[Key]
	[StringLength(20)]
	public string CAI_DOC { get; set; }

	public bool? CAI_INATIVA { get; set; }

	public byte? CAI_SISTEMA2 { get; set; }

	public byte? CAI_RETIRADA2 { get; set; }

	public DateTime? CAI_ATUALIZACAO { get; set; }

	public byte? CAI_TIPO { get; set; }

	public double? CAI_DESCONTO_PROMOCIONAL { get; set; }

	public double? CAI_PRODUTOS { get; set; }

	public bool? CAI_NAO_COMPUTA_VENDA { get; set; }

	public short? CAI_CANAL { get; set; }

	public bool? CAI_DELIVERY { get; set; }

	public virtual ICollection<VENDAS> VENDAS { get; set; }

	public virtual CLIENTES CLIENTES { get; set; }

	public virtual FILIAL FILIAL { get; set; }

	public virtual ICollection<CAIXAFORMA> CAIXAFORMA { get; set; }

	public virtual ICollection<CAIXAPIX> CAIXAPIX { get; set; }

	public virtual ICollection<PARCELAS_CARTAO> PARCELAS_CARTAO { get; set; }

	public virtual CAIXACODIGOEXTERNO CAIXACODIGOEXTERNO { get; set; }

	public virtual CAIXAOBS CAIXAOBS { get; set; }

	[NotMapped]
	public string NFeLog { get; set; }

	[NotMapped]
	public List<string> NFeXMLEnviado { get; set; }

	[NotMapped]
	public string NFeXMLRetorno { get; set; }

	[NotMapped]
	public string NFeXMLNotaProcessada { get; set; }

	[NotMapped]
	public string NFeChave { get; set; }

	[NotMapped]
	public string NFeQRCode { get; set; }

	[NotMapped]
	[Obsolete("Esse campo tem que começar a parar de ser usado pois já tem uma propriedade com a classe correspondente a tabela.")]
	public string ExtensaoObservacao { get; set; }

	[NotMapped]
	[Obsolete("Esse campo tem que começar a parar de ser usado pois já tem uma propriedade com a classe correspondente a tabela.")]
	public string ExtensaoCodigoExterno { get; set; }

	//[NotMapped]
	//[Obsolete("Esse campo tem que começar a parar de ser usado pois já tem uma propriedade com a classe correspondente a tabela.")]
	//public enumStatusIntegracaoEcommerce ExtensaoStatus { get; set; }

	[NotMapped]
	[Obsolete("Esse campo tem que começar a parar de ser usado pois já tem uma propriedade com a classe correspondente a tabela.")]
	public DateTime? ExtensaoStatusAtualizacao { get; set; }

	[NotMapped]
	public CLIENTES ExtensaoCliente { get; set; }

	[NotMapped]
	public double ValorICMS { get; set; }

	//[NotMapped]
	//public List<VendaPlanoPagamento> PlanosPagamento { get; set; }
}
