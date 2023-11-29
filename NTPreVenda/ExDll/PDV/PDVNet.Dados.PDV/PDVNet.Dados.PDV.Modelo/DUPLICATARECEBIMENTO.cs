using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DUPLICATARECEBIMENTO")]
public class DUPLICATARECEBIMENTO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string DUR_DOC_BAIXA { get; set; }

	public int? DUR_FILIAL { get; set; }

	[StringLength(8)]
	public string DUR_DUPLICATA { get; set; }

	public byte? DUR_TIPO { get; set; }

	public DateTime? DUR_CADASTRO { get; set; }

	public DateTime? DUR_PAGAMENTO { get; set; }

	public short? DUR_BANCO { get; set; }

	[StringLength(5)]
	public string DUR_AGENCIA { get; set; }

	[StringLength(10)]
	public string DUR_CONTA { get; set; }

	public DateTime? DUR_VENCIMENTO { get; set; }

	public double? DUR_VALOR { get; set; }

	public byte? DUR_STATUS { get; set; }

	public DateTime? DUR_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string DUR_MATRICULA { get; set; }

	[StringLength(3)]
	public string DUR_CONTA_DESTINO { get; set; }

	[StringLength(6)]
	public string DUR_CHEQUE { get; set; }

	public int? DUR_EXTRATO { get; set; }

	public short? DUR_SERIE { get; set; }

	public double? DUR_JUROS { get; set; }

	public double? DUR_DESCONTO { get; set; }

	[Key]
	[Column(Order = 1)]
	public Guid DUR_GUID { get; set; }
}
