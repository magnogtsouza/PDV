using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class VERSOES
{
	public byte VER_SISTEMA { get; set; }

	public DateTime VER_VERSAO { get; set; }

	public DateTime? VER_DATA { get; set; }

	public DateTime? VER_ANTERIOR { get; set; }

	[StringLength(5)]
	public string VER_DESCRICAO { get; set; }

	[Key]
	public short? VER_CODIGO_VERSAO { get; set; }

	public short? VER_CODIGO { get; set; }

	public bool? VER_SINCRONIZADA { get; set; }
}
