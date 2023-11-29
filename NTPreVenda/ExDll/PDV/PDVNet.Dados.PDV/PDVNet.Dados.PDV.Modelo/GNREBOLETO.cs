using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("GNREBOLETO")]
public class GNREBOLETO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string GBO_DOC_NOTA { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte GBO_SEQ { get; set; }

	[StringLength(10)]
	public string GBO_RECIBO { get; set; }

	public bool? GBO_HOMOLOGACAO { get; set; }

	public byte? GBO_UF_FAVORECIDA { get; set; }

	public int? GBO_RECEITA { get; set; }

	[StringLength(16)]
	public string GBO_NOSSO_NUMERO { get; set; }

	public DateTime? GBO_VENCIMENTO { get; set; }

	public double? GBO_VALOR { get; set; }

	public double? GBO_JUROS { get; set; }

	public double? GBO_MULTA { get; set; }

	public DateTime? GBO_VALIDADE_PAGAMENTO { get; set; }

	[StringLength(48)]
	public string GBO_LINHA_DIGITAVEL { get; set; }

	[StringLength(44)]
	public string GBO_CODIGO_BARRA { get; set; }

	public string GBO_INFORMACOES_COMPLEMENTARES { get; set; }

	[StringLength(8)]
	public string GBO_MATRICULA { get; set; }

	public DateTime? GBO_CADASTRO { get; set; }

	public bool? GBO_INATIVO { get; set; }
}
