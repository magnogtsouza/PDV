using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class ESTOQUES
{
	[Key]
	[StringLength(3)]
	public string EST_CODIGO { get; set; }

	public DateTime? EST_DATA { get; set; }

	public DateTime? EST_CADASTRO { get; set; }

	[StringLength(8)]
	public string EST_MATRICULA { get; set; }

	[StringLength(30)]
	public string EST_NOME { get; set; }

	public byte? EST_REDE { get; set; }

	public short? EST_LIVRO_FISCAL { get; set; }
}
