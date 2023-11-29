using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class FUNCIONARIOS
{
	[Key]
	[StringLength(8)]
	public string FUN_CODIGO { get; set; }

	[StringLength(50)]
	public string FUN_NOME { get; set; }

	[StringLength(20)]
	public string FUN_APELIDO { get; set; }

	[StringLength(6)]
	public string FUN_PREFIXO { get; set; }

	[StringLength(15)]
	public string FUN_FAX { get; set; }

	[StringLength(15)]
	public string FUN_TELEFONE { get; set; }

	[StringLength(14)]
	public string FUN_CPF { get; set; }

	[StringLength(15)]
	public string FUN_IDENTIDADE { get; set; }

	[StringLength(100)]
	public string FUN_OBSERVACAO { get; set; }

	public DateTime? FUN_NASCIMENTO { get; set; }

	[StringLength(20)]
	public string FUN_PROFISSAO { get; set; }

	public short? FUN_FILIAL { get; set; }

	public double? FUN_FIXO { get; set; }

	public double? FUN_VALOR_HORA { get; set; }

	public DateTime? FUN_CADASTRO { get; set; }

	public DateTime? FUN_ATUALIZACAO { get; set; }

	[StringLength(50)]
	public string FUN_EMAIL { get; set; }

	[StringLength(16)]
	public string FUN_CHAVE { get; set; }

	public byte? FUN_TIPO_CADASTRO { get; set; }

	public bool? FUN_INATIVO { get; set; }

	public short? FUN_BANCO { get; set; }

	public byte? FUN_SEXO { get; set; }

	[StringLength(70)]
	public string FUN_NACIONALIDADE { get; set; }

	[StringLength(5)]
	public string FUN_AGENCIA { get; set; }

	[StringLength(10)]
	public string FUN_CONTA { get; set; }

	public byte? FUN_TIPO_CONTA { get; set; }

	public byte? FUN_TIPO_CALCULO_SALARIAL { get; set; }

	public byte? FUN_DEPARTAMENTO { get; set; }

	public byte? FUN_CARGO { get; set; }

	public DateTime? FUN_ADMISSAO { get; set; }

	public DateTime? FUN_DEMISSAO { get; set; }

	public virtual ENDERECO ENDERECO { get; set; }
}
