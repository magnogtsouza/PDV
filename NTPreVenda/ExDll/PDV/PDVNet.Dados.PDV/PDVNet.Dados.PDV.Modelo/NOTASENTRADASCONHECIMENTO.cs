using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NOTASENTRADASCONHECIMENTO")]
public class NOTASENTRADASCONHECIMENTO
{
	[Key]
	[StringLength(20)]
	public string NEC_DOC { get; set; }

	public byte? NEC_TOMADOR { get; set; }

	public DateTime? NEC_EMISSAO { get; set; }

	[StringLength(1)]
	public string NEC_SERIE { get; set; }

	[StringLength(2)]
	public string NEC_SUBSERIE { get; set; }

	[StringLength(6)]
	public string NEC_NUMERO { get; set; }

	[StringLength(2)]
	public string NEC_MODELO { get; set; }

	public short? NEC_CFOP { get; set; }

	public double? NEC_VALOR { get; set; }

	public double? NEC_BC_ICMS { get; set; }

	public double? NEC_VALOR_ICMS { get; set; }

	public double? NEC_VALOR_DESCONTO { get; set; }

	public short? NEC_TRANSPORTADORA { get; set; }

	[StringLength(50)]
	public string NEC_CTE_CHAVE { get; set; }

	public double? NEC_ICMS_ALIQUOTA { get; set; }

	public DateTime? NEC_AQUISICAO { get; set; }
}
