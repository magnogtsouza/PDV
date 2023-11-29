using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("PRINCIPAL")]
public class PRINCIPAL
{
	[StringLength(6)]
	public string PRI_VENDA { get; set; }

	[StringLength(1)]
	public string PRI_IMPRESSORA { get; set; }

	[StringLength(50)]
	public string PRI_MENSAGEM { get; set; }

	[StringLength(6)]
	public string PRI_CUPOM { get; set; }

	[StringLength(4)]
	public string PRI_PORTA { get; set; }

	[StringLength(1)]
	public string PRI_GAVETA { get; set; }

	[StringLength(1)]
	public string PRI_VENDEDOR { get; set; }

	[StringLength(1)]
	public string PRI_ESTOQUE { get; set; }

	[StringLength(1)]
	public string PRI_IMPRESSORA_CHEQUE { get; set; }

	[StringLength(6)]
	public string PRI_PAGAMENTO { get; set; }

	[StringLength(4)]
	public string PRI_PORTA_CHEQUE { get; set; }

	[StringLength(6)]
	public string PRI_PEDIDO { get; set; }

	[StringLength(1)]
	public string PRI_DECORADOR { get; set; }

	[StringLength(5)]
	public string PRI_VERSAO { get; set; }

	[StringLength(1)]
	public string PRI_NOME_IMPRESSORA { get; set; }

	public double? PRI_ACRESCIMO { get; set; }

	[StringLength(1)]
	public string PRI_PRECO { get; set; }

	public double? PRI_ICMS { get; set; }

	[StringLength(6)]
	public string PRI_DISTRIBUICAO { get; set; }

	[StringLength(6)]
	public string PRI_CLIENTE { get; set; }

	public short? PRI_MARGEM_ESQUERDA_NOTA { get; set; }

	public byte? PRI_TRANSFERENCIA { get; set; }

	[StringLength(6)]
	public string PRI_ROMANEIO_SAIDA { get; set; }

	[StringLength(6)]
	public string PRI_PEDIDO_VENDA { get; set; }

	[StringLength(10)]
	public string PRI_SISTEMA { get; set; }

	public short? PRI_SEQ_TEF { get; set; }

	public byte? PRI_TEF { get; set; }

	public byte? PRI_RETIRADA { get; set; }

	[StringLength(6)]
	public string PRI_ENTRADA_SAIDA { get; set; }

	public byte? PRI_PREVISAO { get; set; }

	[StringLength(3)]
	public string PRI_PREVISAO_CLA { get; set; }

	[StringLength(4)]
	public string PRI_PREVISAO_CEN { get; set; }

	[StringLength(6)]
	public string PRI_LANCAMENTO { get; set; }

	public byte? PRI_ITENS_NOTA { get; set; }

	[StringLength(20)]
	public string PRI_AGRUPAR { get; set; }

	public byte? PRI_LOG { get; set; }

	[StringLength(6)]
	public string PRI_RECEBER { get; set; }

	public byte? PRI_PEDIDO_UNICO { get; set; }

	public byte? PRI_IPI { get; set; }

	[StringLength(6)]
	public string PRI_BONUS { get; set; }

	[StringLength(50)]
	public string PRI_NOMINAL { get; set; }

	[StringLength(6)]
	public string PRI_CLIENTE_VAREJO { get; set; }

	public byte? PRI_TIPO_PEDIDO { get; set; }

	public byte? PRI_AUDITORIA { get; set; }

	public string PRI_MENSAGEM2 { get; set; }

	public byte? PRI_TEF2 { get; set; }

	[StringLength(15)]
	public string PRI_TEF_IP { get; set; }

	[StringLength(8)]
	public string PRI_TEF_LOJA { get; set; }

	[StringLength(8)]
	public string PRI_TEF_TERMINAL { get; set; }

	public byte? PRI_IMPNFISCAL { get; set; }

	public byte? PRI_PORTANFISCAL { get; set; }

	public byte? PRI_HLOG { get; set; }

	[StringLength(13)]
	public string PRI_PREVENDA { get; set; }

	public byte? PRI_ATUALIZASALDO { get; set; }

	public byte? PRI_MODULO_WEB { get; set; }

	public byte? PRI_REDEFINANCEIRO { get; set; }

	public short? PRI_MAXIMO_ENTREGA_DIA { get; set; }

	[StringLength(40)]
	public string PRI_ATUALIZANDO { get; set; }

	public DateTime? PRI_ATUALIZANDO_INICIO { get; set; }

	public short? PRI_MAXIMO_ITEM_NFE { get; set; }

	public short? PRI_FORM_PEDIDO_VENDA_PADRAO { get; set; }

	[StringLength(1)]
	public string PRI_PAGAMENTO_CONSIGNATARIO { get; set; }

	[StringLength(1)]
	public string PRI_PAGAMENTO_DECORADOR { get; set; }

	public string PRI_DIRETORIO_ARQUIVOS_CARTAO { get; set; }
}
