using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CLIENTECLASSIFICACAO")]
public class CLIENTECLASSIFICACAO
{
	[Key]
	[Column(Order = 0)]
	public byte CCF_CODIGO { get; set; }

	[StringLength(50)]
	public string CCF_DESCRICAO { get; set; }

	public bool? CCF_INATIVO { get; set; }

	[StringLength(8)]
	public string CCF_MATRICULA { get; set; }

	public DateTime? CCF_CADASTRO { get; set; }

	public DateTime? CCF_ATUALIZACAO { get; set; }

	public double? CCF_FATOR { get; set; }
}
