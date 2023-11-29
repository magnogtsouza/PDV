using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class DUPLICATAS
{
	[StringLength(9)]
	public string DUP_NOTA { get; set; }

	public short DUP_FILIAL { get; set; }

	[StringLength(8)]
	public string DUP_DUPLICATA { get; set; }

	public DateTime? DUP_VENCIMENTO { get; set; }

	public DateTime? DUP_CADASTRO { get; set; }

	public double? DUP_VALOR { get; set; }

	public DateTime? DUP_PAGAMENTO { get; set; }

	public double? DUP_VALOR_PAGO { get; set; }

	public double? DUP_DESCONTO { get; set; }

	public byte? DUP_TIPO { get; set; }

	[StringLength(200)]
	public string DUP_OBS { get; set; }

	public DateTime? DUP_FLUXO { get; set; }

	public double? DUP_JUROS { get; set; }

	public double? DUP_VALOR_NOTA { get; set; }

	[StringLength(16)]
	public string DUP_CODIGON { get; set; }

	[StringLength(5)]
	public string DUP_PARCELAS { get; set; }

	public DateTime? DUP_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string DUP_MATRICULA { get; set; }

	public byte? DUP_STATUS2 { get; set; }

	[StringLength(20)]
	public string DUP_NOTA_DOC { get; set; }

	public short DUP_SERIE { get; set; }

	public int? DUP_EXTRATO { get; set; }

	public int? DUP_BORDERO { get; set; }

	public short DUP_CONTA_DESTINO { get; set; }

	public short? DUP_REPRESENTANTE { get; set; }

	[StringLength(3)]
	public string DUP_CUSTODIA { get; set; }

	public short? DUP_REMESSA { get; set; }

	[StringLength(25)]
	public string DUP_NUMERO_CONTROLE { get; set; }

	[StringLength(20)]
	public string DUP_NOSSO_NUMERO { get; set; }

	public double? DUP_PERCENTUAL_MULTA { get; set; }

	public DateTime? DUP_DATA_MULTA { get; set; }

	public byte? DUP_CARTEIRA { get; set; }

	[StringLength(2)]
	public string DUP_INSTRUCAO1 { get; set; }

	[StringLength(2)]
	public string DUP_INSTRUCAO2 { get; set; }

	[StringLength(10)]
	public string DUP_SEU_NUMERO { get; set; }

	public double? DUP_VALOR_MORA { get; set; }

	public byte? DUP_DIAS_PROTESTO { get; set; }

	public short? DUP_BANCO { get; set; }

	public byte? DUP_CONTROLE_REMESSA { get; set; }

	[StringLength(20)]
	public string DUP_CAIXA_DOC { get; set; }

	public short? DUP_CLASSIFICACAO { get; set; }

	public short? DUP_STATUS { get; set; }

	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public Guid DUP_GUID { get; set; }
}
