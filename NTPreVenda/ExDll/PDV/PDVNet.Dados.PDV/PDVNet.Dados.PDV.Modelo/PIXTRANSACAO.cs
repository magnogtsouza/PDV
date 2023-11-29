using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class PIXTRANSACAO
{
	[Key]
	[Column(Order = 0)]
	public Guid PIT_ID { get; set; }

	[Key]
	[Column(Order = 1)]
	public int PIT_SEQ { get; set; }

	public double PIT_VALOR { get; set; }

	public short PIT_STATUS { get; set; }

	public DateTime? PIT_CADASTRO { get; set; }

	[MaxLength(8)]
	public string PIT_MATRICULA { get; set; }

	[NotMapped]
	public string deep_link { get; set; }

	[NotMapped]
	public string qr_code { get; set; }

	[NotMapped]
	public string qr_code_text { get; set; }
}
