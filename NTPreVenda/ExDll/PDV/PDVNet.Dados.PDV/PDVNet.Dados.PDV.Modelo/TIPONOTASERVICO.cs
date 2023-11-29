using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TIPONOTASERVICO")]
public class TIPONOTASERVICO
{
	[Key]
	[Column(Order = 0)]
	public short TNS_CODIGO { get; set; }

	[StringLength(50)]
	public string TNS_DESCRICAO { get; set; }

	public byte? TNS_MODELO { get; set; }

	[StringLength(14)]
	public string TNS_SERVICO { get; set; }

	public double? TNS_VALOR { get; set; }

	public byte? TNS_TABELA { get; set; }

	public short? TNS_CONDICAO { get; set; }

	public short? TNS_NATUREZA_OPERACAO { get; set; }

	public short? TNS_CLAS_FINANCEIRA { get; set; }

	public DateTime? TNS_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string TNS_MATRICULA { get; set; }

	public bool? TNS_INATIVO { get; set; }

	[StringLength(255)]
	public string TNS_OBS { get; set; }

	public double? TNS_COFINS { get; set; }

	public double? TNS_CSLL { get; set; }

	public double? TNS_IRPJ { get; set; }

	public double? TNS_PIS { get; set; }

	public short? TNS_TIPOPESSOA { get; set; }

	[NotMapped]
	public string ServicoDescricao { get; set; }

	[NotMapped]
	public string ServicoNBS { get; set; }

	[NotMapped]
	public string CondicaoPagamentoDescricao { get; set; }

	[NotMapped]
	public string ClassificacaoFinanceiraDescricao { get; set; }
}
