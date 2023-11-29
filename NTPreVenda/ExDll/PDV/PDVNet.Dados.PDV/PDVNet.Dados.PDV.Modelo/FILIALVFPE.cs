using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class FILIALVFPE
{
	[Key]
	[Column(Order = 0)]
	public short FVP_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte FVP_SEQ { get; set; }

	public short? FVP_ADQUIRENTE { get; set; }

	[StringLength(50)]
	public string FVP_CHAVEREQUISICAO { get; set; }

	[StringLength(10)]
	public string FVP_CODIGOESTABELECIMENTO { get; set; }

	[StringLength(40)]
	public string FVP_NUMERO_LOGICO { get; set; }

	public DateTime? FVP_ATUALIZACAO { get; set; }

	public bool? FVP_INATIVO { get; set; }

	[StringLength(8)]
	public string FVP_MATRICULA { get; set; }
}
