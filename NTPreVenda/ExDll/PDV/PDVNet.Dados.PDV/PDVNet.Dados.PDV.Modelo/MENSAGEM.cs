using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MENSAGEM")]
public class MENSAGEM
{
	[Key]
	[Column(Order = 0)]
	public short MEN_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short MEN_FILIAL_ORIGEM { get; set; }

	[Key]
	[Column(Order = 2)]
	public bool MEN_ORIGEM_PDV { get; set; }

	public string MEN_MENSAGEM { get; set; }

	public DateTime? MEN_VALIDADE { get; set; }

	public DateTime? MEN_CADASTRO { get; set; }

	public bool? MEN_INATIVO { get; set; }

	[StringLength(8)]
	public string MEN_MATRICULA { get; set; }

	public DateTime? MEN_ATUALIZACAO { get; set; }
}
