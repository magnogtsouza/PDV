using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REDEPIXCLIENTE")]
public class REDEPIXCLIENTE
{
	[Key]
	[Column(Order = 0)]
	public Guid REC_ID_REDE { get; set; }

	public int? REC_CLIENTE { get; set; }

	public double? REC_TAXA { get; set; }

	[StringLength(100)]
	public string REC_EMAIL { get; set; }

	public string REC_ACCESS_KEY { get; set; }

	public string REC_SECRET_KEY { get; set; }

	[StringLength(16)]
	public Guid REC_USUARIO_ID { get; set; }

	[StringLength(15)]
	public string REC_TELEFONE { get; set; }
}
