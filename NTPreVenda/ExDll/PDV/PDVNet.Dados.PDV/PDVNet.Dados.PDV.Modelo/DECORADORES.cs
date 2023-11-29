using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class DECORADORES
{
	[Key]
	[StringLength(8)]
	public string DEC_CODIGO { get; set; }

	[StringLength(50)]
	public string DEC_NOME { get; set; }

	[StringLength(6)]
	public string DEC_PREFIXO { get; set; }

	[StringLength(15)]
	public string DEC_TELEFONE { get; set; }

	public double? DEC_COMISSAO { get; set; }

	[StringLength(14)]
	public string DEC_CPF { get; set; }

	[StringLength(15)]
	public string DEC_IDENTIDADE { get; set; }

	[StringLength(100)]
	public string DEC_OBSERVACAO { get; set; }

	public DateTime? DEC_NASCIMENTO { get; set; }

	[StringLength(20)]
	public string DEC_PROFISSAO { get; set; }

	[StringLength(50)]
	public string DEC_EMAIL { get; set; }

	[StringLength(15)]
	public string DEC_CELULAR { get; set; }

	public short? DEC_BANCO { get; set; }

	[StringLength(5)]
	public string DEC_AGENCIA { get; set; }

	[StringLength(10)]
	public string DEC_CONTA { get; set; }

	public bool? DEC_INATIVO { get; set; }

	public DateTime? DEC_CADASTRO { get; set; }

	public DateTime? DEC_ATUALIZACAO { get; set; }

	[StringLength(16)]
	public string DEC_CHAVE { get; set; }

	public byte? DEC_TIPO_CADASTRO { get; set; }
}
