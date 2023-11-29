using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CREDIARIO")]
public class CREDIARIO
{
	[Key]
	[StringLength(22)]
	public string CRE_DOCUMENTO { get; set; }

	[StringLength(6)]
	public string CRE_CODIGO { get; set; }

	public short? CRE_FILIAL { get; set; }

	public DateTime? CRE_DATA { get; set; }

	public DateTime? CRE_CADASTRO { get; set; }

	[StringLength(12)]
	public string CRE_CONTRATO { get; set; }

	public DateTime? CRE_VENCIMENTO { get; set; }

	public byte? CRE_STATUS { get; set; }

	public double? CRE_VALOR { get; set; }

	public double? CRE_VALOR_PAGO { get; set; }

	public DateTime? CRE_PAGAMENTO { get; set; }

	public DateTime? CRE_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CRE_MATRICULA { get; set; }

	[StringLength(16)]
	public string CRE_CODIGON { get; set; }

	[StringLength(5)]
	public string CRE_PARCELAS { get; set; }

	[StringLength(6)]
	public string CRE_BAIXA { get; set; }

	[StringLength(12)]
	public string CRE_ORIGINAL { get; set; }

	[StringLength(20)]
	public string CRE_DOC { get; set; }

	public double? CRE_VALOR_JUROS { get; set; }

	public double? CRE_TAXA { get; set; }

	public string CRE_OBS { get; set; }

	public byte? CRE_STATUS_NOVO { get; set; }

	[NotMapped]
	public string CLI_NOME { get; set; }

	[NotMapped]
	public string FIL_RAZAO_SOCIAL { get; set; }

	[NotMapped]
	public string STA_DESCRICAO { get; set; }

	[NotMapped]
	public string ACM_DESCRICAO { get; set; }

	[NotMapped]
	public byte CRC_SEQ { get; set; }

	[NotMapped]
	public bool ACM_TRAVA_PAGAMENTO { get; set; }

	[NotMapped]
	public bool CLI_NEGATIVADO { get; set; }

	[NotMapped]
	public int? DIASATRASO { get; set; }
}
