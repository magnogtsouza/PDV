using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using PDVNet.Util;

namespace PDVNet.Dados.PDV.Modelo;

[Table("PEDIDOSVENDA")]
public class PEDIDOSVENDA
{
	public List<ITENSPEDIDOVENDA> ExtensaoItens { get; set; }

	public string ExtensaoClienteNome { get; set; }

	public string ExtensaoUsuarioNome { get; set; }

	//public double ExtensaoValorLiquido => Calculos.CalcularDesconto(PED_VALOR.ReceberDouble(), PED_DESCONTO.ReceberDouble(), enumTipoOperacaoDesconto.ValorDesconto);

	public double ExtensaoFranquiaTotalPecas { get; set; }

	public double ExtensaoFranquiaValorTotal { get; set; }

	public double ExtensaoFranquiaTotalLiquido { get; set; }

	public byte ExtensaoFinalizado { get; set; }

	public string ExtensaoFranquiaCodigon { get; set; }

	[Key]
	[StringLength(6)]
	public string PED_PEDIDO { get; set; }

	public DateTime? PED_DATA { get; set; }

	public string PED_OBSERVACAO { get; set; }

	public DateTime? PED_CADASTRO { get; set; }

	public short? PED_CONDICAO { get; set; }

	public DateTime? PED_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string PED_MATRICULA { get; set; }

	public short? PED_TRANSPORTADORA { get; set; }

	public byte? PED_FRETE { get; set; }

	[StringLength(16)]
	public string PED_CODIGON { get; set; }

	public short? PED_COD_FORM { get; set; }

	public byte? PED_TIPO_PECAS { get; set; }

	[StringLength(6)]
	public string PED_PEDIDO_EXTERNO { get; set; }

	public short? PED_REPRESENTANTE { get; set; }

	public byte? PED_TAB1 { get; set; }

	public byte? PED_TAB2 { get; set; }

	public short? PED_REDESPACHO { get; set; }

	public double? PED_PECAS { get; set; }

	public double? PED_VALOR { get; set; }

	public DateTime? PED_D_ENTREGA { get; set; }

	public byte? PED_TIPO_PEDIDO { get; set; }

	public byte? PED_SINCRO { get; set; }

	public short? PED_COTA { get; set; }

	public DateTime? PED_INICIO_ENTREGA { get; set; }

	public DateTime? PED_FIM_ENTREGA { get; set; }

	public byte? PED_ENDERECO { get; set; }

	public double? PED_DESCONTO { get; set; }

	public double? PED_PECAS_ENTREGUE { get; set; }

	public double? PED_VALOR_ENTREGUE { get; set; }

	public double? PED_META { get; set; }

	public byte? PED_STATUS_WEB { get; set; }

	public double? PED_VALOR_FRETE { get; set; }

	public bool? PED_TIPO_DESCONTO { get; set; }

	public byte? PED_STATUS_NOVO { get; set; }

	[StringLength(20)]
	public string PED_DOC_VENDA { get; set; }

	public short? PED_NATUREZA_OPERACAO { get; set; }

	[NotMapped]
	public virtual List<ITENSPEDIDOVENDA> ITENSPEDIDOVENDA { get; set; }
}
