using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class IMAGEM
{
	[Key]
	[Column(Order = 0)]
	public byte IMA_TIPO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(16)]
	public string IMA_CODIGO { get; set; }

	[Key]
	[Column(Order = 2)]
	public short IMA_REDE { get; set; }

	[Key]
	[Column(Order = 3)]
	public short IMA_SEQ { get; set; }

	public byte[] IMA_IMAGEM { get; set; }

	[StringLength(4)]
	public string IMA_EXTENSAO { get; set; }

	public bool IMA_INATIVA { get; set; }

	[StringLength(8)]
	public string IMA_MATRICULA { get; set; }

	public DateTime? IMA_ATUALIZACAO { get; set; }

	[StringLength(250)]
	public string IMA_LINK { get; set; }
}
