using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class PIXFILIALINTEGRACAO
{
	[Key]
	[Column(Order = 0)]
	public short FIM_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public short PIF_PIX_INTEGRACAO { get; set; }

	public Guid? PIF_CONTA { get; set; }
}
