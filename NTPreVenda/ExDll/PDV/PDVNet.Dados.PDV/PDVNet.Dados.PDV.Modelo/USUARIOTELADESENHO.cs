using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("USUARIOTELADESENHO")]
public class USUARIOTELADESENHO
{
	[Key]
	[StringLength(6)]
	public string USD_CODIGO { get; set; }

	[StringLength(8)]
	public string USD_USUARIO { get; set; }

	public byte? USD_TELA { get; set; }

	[StringLength(30)]
	public string USD_NOME { get; set; }

	public DateTime? USD_CADASTRO { get; set; }

	public DateTime? USD_ATUALIZACAO { get; set; }

	public bool? USD_EXCLUIDO { get; set; }
}
