using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REMESSACONFIGURACAO")]
public class REMESSACONFIGURACAO
{
	[Key]
	public byte REC_CODIGO { get; set; }

	[Required]
	[StringLength(3)]
	public string REC_BANCO { get; set; }

	[StringLength(50)]
	public string REC_DESCRICAO { get; set; }

	public double? REC_PERCENTUAL_MULTA { get; set; }

	public byte? REC_DIAS_MULTA { get; set; }

	public double? REC_PERCENTUAL_MORA { get; set; }

	[StringLength(2)]
	public string REC_INSTRUCAO1 { get; set; }

	[StringLength(2)]
	public string REC_INSTRUCAO2 { get; set; }

	public bool? REC_INATIVO { get; set; }

	public DateTime? REC_CADASTRO { get; set; }

	public DateTime? REC_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string REC_MATRICULA { get; set; }

	public byte? REC_DIAS_PROTESTO { get; set; }
}
