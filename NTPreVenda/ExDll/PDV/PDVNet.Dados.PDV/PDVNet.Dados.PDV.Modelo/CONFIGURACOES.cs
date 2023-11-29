using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CONFIGURACOES
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CON_FILIAL { get; set; }

	public double? CON_DESCONTO_PERCENTUAL { get; set; }

	public short? CON_MAXIMO_CARTAO_PARCELAS { get; set; }

	public double? CON_MINIMO_CARTAO { get; set; }

	public double? CON_DIAS { get; set; }

	public double? CON_MINIMO_DEBITO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte CON_REDE { get; set; }

	public byte? CON_PRECO_VENDA { get; set; }

	public byte? CON_CONSULTA_MOVIMENTO { get; set; }

	public byte? CON_EMBALAGEM { get; set; }

	public byte? CON_CPF { get; set; }

	public byte? CON_IMPRIMIR { get; set; }

	public byte? CON_FRETE { get; set; }

	public short? CON_DIAS_MAXIMO_CHEQUE { get; set; }

	public byte? CON_ALTERAR_PRECO2 { get; set; }

	public byte? CON_EXIGE_CLIENTE2 { get; set; }

	public byte? CON_EXIBE_CUSTO2 { get; set; }

	public byte? CON_EXIBE_ESTOQUE2 { get; set; }

	public byte? CON_EXIBE_QTD2 { get; set; }

	public byte? CON_SENHA_DESCONTO2 { get; set; }

	public byte? CON_CONTA2 { get; set; }

	public byte? CON_VALE2 { get; set; }

	public byte? CON_EXIGIR_VALE2 { get; set; }

	public byte? CON_PLANO2 { get; set; }

	public byte? CON_CARTAO2 { get; set; }

	public byte? CON_CAMBIO2 { get; set; }

	public byte? CON_TRANSFERENCIA2 { get; set; }

	public byte? CON_MOVIMENTO2 { get; set; }

	public byte? CON_SENHA_PRECO2 { get; set; }

	public byte? CON_HORARIO2 { get; set; }

	public byte? CON_CLIENTE_PARCIAL { get; set; }

	public byte? CON_FIDELIDADE { get; set; }

	public byte? CON_FIDELIDADE_LOJA { get; set; }

	public byte? CON_AGUARDAR { get; set; }

	public byte? CON_SEM_PEDIDO { get; set; }

	public byte? CON_ALTERA_CUSTO { get; set; }

	public byte? CON_ENVIA_VALE { get; set; }

	public byte? CON_SENHA_CANCELAMENTO { get; set; }

	public byte? CON_VIAS_PREVENDA { get; set; }

	public double? CON_TAXA_JUROS { get; set; }

	public DateTime? CON_ATUALIZACAO { get; set; }

	public byte? CON_CREDIARIO_TOLERANCIA_JUROS_DIAS { get; set; }

	public double? CON_MARGEM_LIMITE_CREDIARIO { get; set; }

	public double? CON_LIMITE_CREDITO_PADRAO { get; set; }

	public byte? CON_FECHAR_PREVENDA_DIAS { get; set; }

	public short? CON_QTD_MAXIMA_ITENS_VENDA { get; set; }

	public double? CON_VALOR_MAXIMO_ITEM_VENDA { get; set; }

	public double? CON_PEDIDO_VENDA_MARKUP_MINIMO { get; set; }

	public short? CON_DIAS_LIMITE_CREDIARIO { get; set; }

	public virtual ICollection<CONFIGURAVALORES> CONFIGURAVALORES { get; set; }
}
