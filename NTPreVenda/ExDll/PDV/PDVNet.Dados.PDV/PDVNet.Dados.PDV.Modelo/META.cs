using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("META")]
public class META
{
	[Key]
	public short MET_CODIGO { get; set; }

	public DateTime? MET_INICIO { get; set; }

	public DateTime? MET_FIM { get; set; }

	public short? MET_FILIAL { get; set; }

	public double? MET_VALOR { get; set; }

	public bool? MET_TIPO { get; set; }

	public DateTime? MET_CADASTRO { get; set; }

	[StringLength(8)]
	public string MET_MATRICULA { get; set; }

	public DateTime? MET_ATUALIZACAO { get; set; }

	public double? MET_TROCA { get; set; }

	public bool? MET_UNICO { get; set; }
}
