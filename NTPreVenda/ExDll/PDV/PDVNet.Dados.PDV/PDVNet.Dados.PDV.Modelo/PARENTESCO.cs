using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("PARENTESCO")]
public class PARENTESCO
{
	[Key]
	public byte PAR_CODIGO { get; set; }

	[StringLength(30)]
	public string PAR_NOME { get; set; }

	public byte? PAR_SEXO { get; set; }

	public bool? PAR_INATIVO { get; set; }

	public DateTime? PAR_CADASTRO { get; set; }

	public DateTime? PAR_ATUALIZACAO { get; set; }
}
