using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CLIENTECODIGO")]
public class CLIENTECODIGO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(16)]
	public string CCO_CODIGON { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(16)]
	public string CCO_ANTERIOR { get; set; }

	[StringLength(8)]
	public string CCO_CGC { get; set; }

	public DateTime? CCO_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CCO_MATRICULA { get; set; }
}
