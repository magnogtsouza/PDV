using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REMESSA")]
public class REMESSA
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int REM_CODIGO { get; set; }

	public short? REM_BANCO { get; set; }

	public short? REM_FILIAL { get; set; }

	[StringLength(40)]
	public string REM_OBS { get; set; }

	public DateTime? REM_CADASTRO { get; set; }

	public DateTime? REM_ATUALIZACAO { get; set; }

	public string REM_MATRICULA { get; set; }

	public byte? REM_STATUS { get; set; }

	public bool? REM_INATIVO { get; set; }

	public byte? REM_CONFIGURACAO { get; set; }

	[StringLength(3)]
	public string REM_CONTA { get; set; }

	[StringLength(3)]
	public string REM_CARTEIRA { get; set; }

	public double? REM_VALOR_TOTAL { get; set; }
}
