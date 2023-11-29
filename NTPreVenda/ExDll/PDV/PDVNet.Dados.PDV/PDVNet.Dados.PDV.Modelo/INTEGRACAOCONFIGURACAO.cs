using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOCONFIGURACAO
{
	[Key]
	public byte ICO_CODIGO { get; set; }

	[StringLength(100)]
	public string ICO_DESCRICAO { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string ICO_CONFIGURACAO { get; set; }

	public DateTime? ICO_CADASTRO { get; set; }

	public DateTime? ICO_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string ICO_MATRICULA { get; set; }

	public bool? ICO_INATIVO { get; set; }

	public byte? ICO_REDE { get; set; }

	public byte? ICO_PLATAFORMA { get; set; }

	public short? ICO_FILIAL_VENDA { get; set; }

	[StringLength(8)]
	public string ICO_VENDEDOR_VENDA { get; set; }

	[StringLength(8)]
	public string ICO_USUARIO_VENDA { get; set; }

	public byte? ICO_TABELA_CUSTO_BRUTO { get; set; }

	public byte? ICO_TABELA_CUSTO_TOTAL { get; set; }

	public byte? ICO_TABELA_VENDA { get; set; }

	public bool? ICO_GERAR_SEPARACAO_PEDIDO { get; set; }

	public bool? ICO_BAIXAR_PEDIDOS_PAGAMENTO_PENDENTE { get; set; }

	public byte? ICO_TIPO_DESCONTO { get; set; }

	public double? ICO_ESTOQUE_MINIMO { get; set; }

	public bool? ICO_OMNICHANNEL { get; set; }

	public bool? ICO_BAIXAR_DADOS { get; set; }

	public bool? ICO_EXPORTAR_DADOS { get; set; }

	public virtual ICollection<INTEGRACAOFILIALESTOQUE> INTEGRACAOFILIALESTOQUE { get; set; }

	public virtual ICollection<INTEGRACAOTRANSPORTADORAASSOCIACAO> INTEGRACAOTRANSPORTADORAASSOCIACAO { get; set; }

	public virtual ICollection<INTEGRACAOFILIAL> INTEGRACAOFILIAL { get; set; }

	public virtual ICollection<INTEGRACAOCUPOMFILIAL> INTEGRACAOCUPOMFILIAL { get; set; }

	public virtual ICollection<INTEGRACAOCAMPOEXPORTACAO> INTEGRACAOCAMPOEXPORTACAO { get; set; }

	public virtual ICollection<INTEGRACAOFORMAPAGAMENTO> INTEGRACAOFORMAPAGAMENTO { get; set; }
}
