using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class CLAS_FINANCEIRA
{
	[Key]
	[StringLength(3)]
	public string CLA_CODIGO { get; set; }

	[StringLength(30)]
	public string CLA_DESCRICAO { get; set; }

	[StringLength(2)]
	public string CLA_GRUPO { get; set; }

	[StringLength(2)]
	public string CLA_GERENCIAL { get; set; }

	public byte? CLA_LOJA { get; set; }

	public bool? CLA_INATIVA { get; set; }

	public byte? CLA_TIPO2 { get; set; }

	[StringLength(8)]
	public string CLA_MATRICULA { get; set; }

	public DateTime? CLA_CADASTRO { get; set; }

	public DateTime? CLA_ATUALIZACAO { get; set; }

	[StringLength(15)]
	public string CLA_FISCAL { get; set; }

	public byte? CLA_LANCAMENTO { get; set; }

	public byte? CLA_COMPRA { get; set; }

	public byte? CLA_DP { get; set; }

	public string ExtensaoUsuarioNome { get; set; }
}
