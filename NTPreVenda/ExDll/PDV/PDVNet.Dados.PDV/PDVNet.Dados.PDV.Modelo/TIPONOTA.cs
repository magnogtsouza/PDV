using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TIPONOTA")]
public class TIPONOTA
{
	[Key]
	public byte TIP_CODIGO { get; set; }

	[StringLength(30)]
	public string TIP_DESCRICAO { get; set; }

	public byte? TIP_DUPLICATA { get; set; }

	public byte? TIP_TIPO { get; set; }

	[StringLength(8)]
	public string TIP_MATRICULA { get; set; }

	public DateTime? TIP_ATUALIZACAO { get; set; }

	public bool? TIP_INATIVA { get; set; }
}
