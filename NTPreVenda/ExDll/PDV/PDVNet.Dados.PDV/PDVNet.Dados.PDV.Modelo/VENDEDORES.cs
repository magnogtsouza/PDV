using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class VENDEDORES
{
	[Key]
	[StringLength(8)]
	public string VEN_CODIGO { get; set; }

	public string VEN_MATRICULA { get; set; }

	[StringLength(50)]
	public string VEN_NOME { get; set; }

	[StringLength(20)]
	public string VEN_APELIDO { get; set; }

	[StringLength(6)]
	public string VEN_PREFIXO { get; set; }

	[StringLength(15)]
	public string VEN_FAX { get; set; }

	[StringLength(15)]
	public string VEN_TELEFONE { get; set; }

	public double? VEN_COMISSAO { get; set; }

	[StringLength(1)]
	public string VEN_TIPO { get; set; }

	[StringLength(14)]
	public string VEN_CPF { get; set; }

	[StringLength(15)]
	public string VEN_IDENTIDADE { get; set; }

	[StringLength(100)]
	public string VEN_OBSERVACAO { get; set; }

	public DateTime? VEN_NASCIMENTO { get; set; }

	[StringLength(20)]
	public string VEN_PROFISSAO { get; set; }

	[StringLength(20)]
	public string VEN_CREA { get; set; }

	public short? VEN_FILIAL { get; set; }

	public double? VEN_COMISSAO_TOTAL { get; set; }

	public double? VEN_FIXO { get; set; }

	public DateTime? VEN_CADASTRO { get; set; }

	public DateTime? VEN_ATUALIZACAO { get; set; }

	[StringLength(50)]
	public string VEN_EMAIL { get; set; }

	[StringLength(16)]
	public string VEN_CHAVE { get; set; }

	public byte? VEN_TIPO_CADASTRO { get; set; }

	public bool? VEN_INATIVO { get; set; }

	public short? VEN_BANCO { get; set; }

	[StringLength(5)]
	public string VEN_AGENCIA { get; set; }

	[StringLength(10)]
	public string VEN_CONTA { get; set; }

	public byte? VEN_TIPO_CONTA { get; set; }

	public virtual ENDERECO ENDERECO { get; set; }
}
