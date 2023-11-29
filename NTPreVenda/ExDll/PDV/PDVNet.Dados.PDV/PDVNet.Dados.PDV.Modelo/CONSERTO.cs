using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONSERTO")]
public class CONSERTO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string CON_DOC { get; set; }

	public short? CON_FILIAL { get; set; }

	[StringLength(16)]
	public string CON_CODIGON { get; set; }

	public byte CON_STATUS { get; set; }

	public DateTime? CON_DATA { get; set; }

	public DateTime? CON_CADASTRO { get; set; }

	public DateTime? CON_ATUALIZACAO { get; set; }

	public DateTime? CON_DATA_LIMITE_ANALISE { get; set; }

	[StringLength(8)]
	public string CON_MATRICULA { get; set; }

	[NotMapped]
	public List<CONSERTOITEM> ConsertoItens { get; set; }

	[NotMapped]
	public string US_ABREVIADO { get; set; }

	[NotMapped]
	public string CLI_NOME { get; set; }

	[NotMapped]
	public string STA_DESCRICAO { get; set; }
}
