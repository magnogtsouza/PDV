using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("AUTORIZACOES")]
public class AUTORIZACOES
{
	public short? AUT_TIPO { get; set; }

	[StringLength(6)]
	public string AUT_BOLETO { get; set; }

	public short? AUT_filial { get; set; }

	[StringLength(8)]
	public string AUT_MATRICULA { get; set; }

	public DateTime? AUT_DATA { get; set; }

	[StringLength(5)]
	public string AUT_HORA { get; set; }

	[Key]
	[StringLength(20)]
	public string AUT_DOC { get; set; }
}
