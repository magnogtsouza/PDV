using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("IMPRESSORAFISCAL")]
public class IMPRESSORAFISCAL
{
	public short? IMP_FILIAL { get; set; }

	public byte? IMP_CAIXA { get; set; }

	[Key]
	[StringLength(20)]
	public string IMP_SERIAL { get; set; }

	public byte? IMP_CODIGO { get; set; }

	[StringLength(20)]
	public string IMP_MARCA { get; set; }

	[StringLength(20)]
	public string IMP_MODELO { get; set; }

	[StringLength(7)]
	public string IMP_TIPO { get; set; }

	[StringLength(1)]
	public string IMP_MFADICIONAL { get; set; }

	[StringLength(10)]
	public string IMP_VERSAOSB { get; set; }

	public DateTime? IMP_DATASB { get; set; }

	[StringLength(6)]
	public string IMP_IDNACIONAL { get; set; }

	public int? IMP_ASSINA { get; set; }
}
