using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("EXTRATO")]
public class EXTRATO
{
	[Key]
	public int EXT_CONTROLE { get; set; }

	public DateTime? EXT_DATA { get; set; }

	public double? EXT_VALOR { get; set; }

	public DateTime? EXT_CADASTRO { get; set; }

	[StringLength(2)]
	public string EXT_OPERACAO { get; set; }

	[StringLength(6)]
	public string EXT_PAGAMENTO { get; set; }

	public short? EXT_BANCO { get; set; }

	public byte? EXT_CARTAO { get; set; }

	public double? EXT_SALDO { get; set; }

	public int? EXT_CHEQUE { get; set; }

	public DateTime? EXT_COMPENSADO { get; set; }

	[StringLength(150)]
	public string EXT_OBS { get; set; }

	[StringLength(8)]
	public string EXT_MATRICULA { get; set; }

	public byte? EXT_TIPO2 { get; set; }

	public byte? EXT_EXTORNADO { get; set; }

	public byte? EXT_PRE { get; set; }

	[StringLength(6)]
	public string EXT_RECEBER { get; set; }

	[StringLength(6)]
	public string EXT_LANCAMENTO { get; set; }

	[StringLength(4)]
	public string EXT_CCUSTO { get; set; }

	[StringLength(3)]
	public string EXT_CLASS { get; set; }

	public DateTime? EXT_COMPETENCIA { get; set; }
}
