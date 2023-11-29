using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONSUMO")]
public class CONSUMO
{
	[Key]
	[StringLength(20)]
	public string CON_DOC { get; set; }

	public short? CON_FILIAL { get; set; }

	public byte? CON_TABELA_CUSTO { get; set; }

	public DateTime? CON_CADASTRO { get; set; }

	[StringLength(8)]
	public string CON_MATRICULA { get; set; }

	public bool? CON_INATIVO { get; set; }

	public byte? CON_TIPO { get; set; }

	public byte? CON_TABELA_CUSTO_MEDIO { get; set; }
}
