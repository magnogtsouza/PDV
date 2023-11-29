using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TIPODESCONTO")]
public class TIPODESCONTO
{
	[Key]
	public byte TIP_CODIGO { get; set; }

	[StringLength(40)]
	public string TIP_DESCRICAO { get; set; }

	public bool? TIP_INATIVO { get; set; }

	public DateTime? TIP_CADASTRO { get; set; }

	public DateTime? TIP_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string TIP_MATRICULA { get; set; }

	public double? TIP_MAXIMO { get; set; }

	public byte? TIP_TIPO_VALOR { get; set; }

	public double? TIP_VALOR_MINIMO { get; set; }
}
