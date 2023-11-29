using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class PAGAMENTOS
{
	[Key]
	[StringLength(6)]
	public string Pag_Numero { get; set; }

	public short? Pag_Filial { get; set; }

	[StringLength(4)]
	public string Pag_Centro_Custo { get; set; }

	public double? Pag_Valor { get; set; }

	public DateTime? Pag_Emissao { get; set; }

	[StringLength(150)]
	public string Pag_Obs { get; set; }

	[StringLength(12)]
	public string Pag_Nota_Fiscal { get; set; }

	public DateTime? Pag_Vencimento { get; set; }

	[StringLength(12)]
	public string Pag_Duplicata { get; set; }

	[StringLength(2)]
	public string Pag_Moeda { get; set; }

	public byte? Pag_Tipo { get; set; }

	public short PAG_CLASSIFICACAO { get; set; }

	public DateTime? Pag_Pagamento { get; set; }

	[StringLength(6)]
	public string Pag_Fornecedor { get; set; }

	public DateTime? Pag_Cancelamento { get; set; }

	public double? Pag_Valor_Pago { get; set; }

	public DateTime? Pag_Cadastro { get; set; }

	[StringLength(6)]
	public string Pag_Cheque { get; set; }

	[StringLength(1)]
	public string Pag_Status { get; set; }

	public double? PAG_MULTA { get; set; }

	public double? PAG_MORA { get; set; }

	public DateTime? PAG_FLUXO { get; set; }

	[StringLength(5)]
	public string PAG_PARCELAS { get; set; }

	public int? PAG_EXTRATO { get; set; }

	public int? PAG_RELACAO_CHEQUE { get; set; }

	public double? PAG_DESCONTO { get; set; }

	public byte? PAG_EMPRESA { get; set; }

	[StringLength(6)]
	public string PAG_PEDIDO { get; set; }

	[StringLength(8)]
	public string PAG_MATRICULA { get; set; }

	public DateTime? PAG_ATUALIZACAO { get; set; }

	public byte? PAG_ENTRADA_NOTA { get; set; }

	public DateTime? PAG_COMPETENCIA { get; set; }

	public byte? PAG_EXTRA { get; set; }

	[StringLength(44)]
	public string PAG_BARRA { get; set; }
}
