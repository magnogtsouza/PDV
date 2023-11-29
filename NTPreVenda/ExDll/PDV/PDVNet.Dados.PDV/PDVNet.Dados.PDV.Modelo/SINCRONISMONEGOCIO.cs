using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SINCRONISMONEGOCIO")]
public class SINCRONISMONEGOCIO
{
	[Key]
	[Column(Order = 0)]
	public short SIN_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte SIN_TIPO { get; set; }

	[Key]
	[StringLength(20)]
	[Column(Order = 2)]
	public string SIN_DOC { get; set; }

	public byte? SIN_STATUS { get; set; }

	public DateTime? SIN_ATUALIZACAO { get; set; }
}
