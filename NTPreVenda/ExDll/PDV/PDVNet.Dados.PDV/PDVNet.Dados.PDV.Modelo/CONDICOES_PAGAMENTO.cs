using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CONDICOES_PAGAMENTO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CON_CODIGO { get; set; }

	[StringLength(50)]
	public string CON_DESCRICAO { get; set; }

	public short? CON_PARCELAS { get; set; }

	public byte? CON_FORMA { get; set; }

	public double? CON_MINIMO { get; set; }

	public byte? CON_REDE { get; set; }

	public double? CON_VALOR_ENTRADA { get; set; }

	public bool? CON_EXCLUIDA { get; set; }

	public byte? CON_LOJA2 { get; set; }

	public byte? CON_ENTRADA2 { get; set; }

	public byte? CON_FATURAMENTO { get; set; }

	public double? CON_MINIMO_FATURAMENTO { get; set; }

	[StringLength(8)]
	public string CON_MATRICULA { get; set; }

	public DateTime? CON_CADASTRO { get; set; }

	public DateTime? CON_ATUALIZACAO { get; set; }

	public byte? CON_WEB { get; set; }

	public double? CON_MINIMO_WEB { get; set; }

	public byte? CON_CREXIARIO { get; set; }

	public double? CON_JUROS { get; set; }

	public byte? CON_FORMAPAGAMENTO { get; set; }

	public bool? CON_ALIMENTASALDO { get; set; }

	public bool? CON_HABILITATEF { get; set; }

	public bool? CON_NAODUPLICA { get; set; }

	public short? CON_CARTAO { get; set; }

	public short? CON_ORDEM { get; set; }

	public string CON_IDENTIFICACAO { get; set; }

	public bool? CON_VISIVEL { get; set; }

	public byte? CON_TABELA { get; set; }

	public double? CON_FATOR_TABELA { get; set; }
}
