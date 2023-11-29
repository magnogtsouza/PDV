using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ICMS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(3)]
	public string ICMS_CODIGO { get; set; }

	public double? ICMS_VALOR { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte ICMS_IMPRESSORA { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte ICMS_CAIXA { get; set; }

	public byte? ICMS_TIPO { get; set; }

	public DateTime? ICMS_CADASTRO { get; set; }
}
