using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class REFERENCIASCOMENTARIOS
{
	[Required]
	public short REC_COLECAO { get; set; }

	[Key]
	[Column(Order = 0)]
	[StringLength(12)]
	public string REC_REFERENCIA { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte REC_REDE { get; set; }

	[StringLength(255)]
	public string REC_OBS { get; set; }

	[StringLength(255)]
	public string REC_COMENTARIO { get; set; }

	[StringLength(8)]
	public string REC_MATRICULA { get; set; }

	public DateTime? REC_CADASTRO { get; set; }

	[StringLength(5)]
	public string REC_HORA { get; set; }
}
