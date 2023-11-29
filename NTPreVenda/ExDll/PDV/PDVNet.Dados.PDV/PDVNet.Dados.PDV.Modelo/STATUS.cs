using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("STATUS")]
public class STATUS
{
	[Key]
	[Column(Order = 0)]
	public short STA_CODIGO { get; set; }

	[StringLength(30)]
	public string STA_DESCRICAO { get; set; }

	public DateTime? STA_ATUALIZACAO { get; set; }

	public bool? STA_BLOQUEAR { get; set; }
}
