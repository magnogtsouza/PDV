using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("HORARIOVERAO")]
public class HORARIOVERAO
{
	[Key]
	[StringLength(8)]
	public string HOV_CODIGO { get; set; }

	public DateTime? HOV_CADASTRO { get; set; }

	public DateTime? HOV_ATUALIZACAO { get; set; }

	public DateTime? HOV_INICIAL { get; set; }

	public DateTime? HOV_FINAL { get; set; }

	[StringLength(200)]
	public string HOV_ESTADOS { get; set; }

	public bool? HOV_INATIVO { get; set; }
}
