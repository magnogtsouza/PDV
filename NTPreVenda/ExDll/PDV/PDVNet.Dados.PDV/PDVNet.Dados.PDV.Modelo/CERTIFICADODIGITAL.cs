using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class CERTIFICADODIGITAL
{
	[Key]
	public short CDI_CODIGO { get; set; }

	[StringLength(40)]
	public string CDI_DESCRICAO { get; set; }

	[StringLength(14)]
	public string CDI_CPFCNPJ { get; set; }

	public byte? CDI_TIPO { get; set; }

	public DateTime? CDI_EMISSAO { get; set; }

	public string CDI_DADOS { get; set; }

	public DateTime? CDI_VALIDADE { get; set; }

	public DateTime? CDI_CADASTRO { get; set; }

	public DateTime? CDI_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CDI_MATRICULA { get; set; }

	public bool? CDI_INATIVO { get; set; }
}
