using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class DIGITAL
{
	[Key]
	[Column(Order = 0)]
	public byte DIG_TIPO_CADASTRO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(16)]
	public string DIG_CODIGO { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte DIG_SEQ { get; set; }

	public string DIG_DIGITAL { get; set; }

	public DateTime? DIG_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string DIG_MATRICULA { get; set; }

	public bool DIG_INATIVO { get; set; }
}
