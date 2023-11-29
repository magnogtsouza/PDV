using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_XTECH_TAMANHO
{
	[Key]
	[Column(Order = 0)]
	public byte TAM_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short TAM_PDV_CODIGO { get; set; }

	public int? TAM_ID { get; set; }

	public DateTime? TAM_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string TAM_TAMANHO { get; set; }
}
