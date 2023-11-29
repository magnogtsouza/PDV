using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class RETAILAPPVENDAENVIADA
{
	[Key]
	[Column(Order = 0)]
	public byte RVE_CONFIGURACAO { get; set; }

	[Key]
	[StringLength(20)]
	[Column(Order = 1)]
	public string RVE_DOC { get; set; }

	public DateTime? RVE_ULTIMA_EXPORTACAO { get; set; }
}
