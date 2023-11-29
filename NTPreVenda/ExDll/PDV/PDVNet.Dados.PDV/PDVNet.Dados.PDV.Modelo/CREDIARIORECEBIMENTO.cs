using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CREDIARIORECEBIMENTO")]
public class CREDIARIORECEBIMENTO
{
	[Key]
	[StringLength(8)]
	public string CRB_DOC_BAIXA { get; set; }

	[StringLength(22)]
	public string CRB_CREDIARIO { get; set; }

	public short? CRB_FILIAL { get; set; }

	public byte? CRB_TIPO { get; set; }

	public DateTime? CRB_CADASTRO { get; set; }

	public DateTime? CRB_PAGAMENTO { get; set; }

	public short? CRB_BANCO { get; set; }

	[StringLength(5)]
	public string CRB_AGENCIA { get; set; }

	[StringLength(10)]
	public string CRB_CONTA { get; set; }

	public DateTime? CRB_VENCIMENTO { get; set; }

	public double? CRB_VALOR { get; set; }

	public byte? CRB_STATUS { get; set; }

	public DateTime? CRB_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CRB_MATRICULA { get; set; }

	[StringLength(6)]
	public string CRB_CHEQUE { get; set; }
}
