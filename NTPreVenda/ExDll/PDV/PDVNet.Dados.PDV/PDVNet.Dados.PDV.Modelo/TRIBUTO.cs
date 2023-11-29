using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TRIBUTO")]
public class TRIBUTO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(12)]
	public string TRI_REFERENCIA { get; set; }

	public byte? TRI_REDE { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte TRI_TABELA { get; set; }

	public byte? TRI_TIPO { get; set; }

	public double? TRI_VALOR { get; set; }

	public DateTime? TRI_CADASTRO { get; set; }

	public DateTime? TRI_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string TRI_MATRICULA { get; set; }

	public int? TRI_ASSINA { get; set; }

	public virtual REFERENCIAS REFERENCIAS { get; set; }
}
