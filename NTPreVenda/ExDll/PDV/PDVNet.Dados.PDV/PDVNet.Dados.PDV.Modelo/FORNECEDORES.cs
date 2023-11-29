using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class FORNECEDORES
{
	[NotMapped]
	public ENDERECO ExtensaoEndereco { get; set; }

	[Key]
	[StringLength(6)]
	public string FOR_CODIGO { get; set; }

	[StringLength(50)]
	public string FOR_NOME { get; set; }

	[StringLength(18)]
	public string FOR_CGC { get; set; }

	[StringLength(18)]
	public string FOR_INSCRICAO { get; set; }

	[StringLength(30)]
	public string FOR_CONTATO { get; set; }

	[StringLength(30)]
	public string FOR_CARGO { get; set; }

	[StringLength(15)]
	public string FOR_TELEFONE { get; set; }

	[StringLength(15)]
	public string FOR_FAX { get; set; }

	[StringLength(6)]
	public string FOR_PREFIXO { get; set; }

	[StringLength(1)]
	public string FOR_TIPO { get; set; }

	public DateTime? FOR_CADASTRO { get; set; }

	[StringLength(1)]
	public string FOR_CONSIGNACAO { get; set; }

	[StringLength(100)]
	public string FOR_OBSERVACAO { get; set; }

	[StringLength(30)]
	public string FOR_FANTASIA { get; set; }

	[StringLength(1)]
	public string FOR_TIPO_PRODUTO { get; set; }

	[StringLength(15)]
	public string FOR_CELULAR { get; set; }

	public short? FOR_BANCO { get; set; }

	[StringLength(5)]
	public string FOR_AGENCIA { get; set; }

	[StringLength(10)]
	public string FOR_CONTA { get; set; }

	[StringLength(200)]
	public string FOR_EMAIL { get; set; }

	public short? FOR_CONDICAO { get; set; }

	public double? FOR_CREDITO { get; set; }

	public byte? FOR_FRANQUIA { get; set; }

	public DateTime? FOR_ATUALIZACAO { get; set; }

	public bool? FOR_INATIVO { get; set; }

	[StringLength(8)]
	public string FOR_MATRICULA { get; set; }

	public double? FOR_ICMS { get; set; }

	[StringLength(15)]
	public string FOR_TELEFONE2 { get; set; }

	[StringLength(16)]
	public string FOR_CHAVE { get; set; }

	public byte? FOR_TIPO_CADASTRO { get; set; }

	public byte? FOR_LOJA { get; set; }

	[StringLength(70)]
	public string FOR_SITE { get; set; }

	public bool? FOR_ACABADO { get; set; }

	public bool? FOR_MATERIA { get; set; }

	[StringLength(6)]
	public string FOR_FORNECEDOR_PRIMARIO { get; set; }

	public bool? FOR_BLOQUEIO_XML { get; set; }
}
