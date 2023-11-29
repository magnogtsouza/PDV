using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALEMAIL")]
public class FILIALEMAIL
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short FIE_FILIAL { get; set; }

	[StringLength(50)]
	public string FIE_EMAIL { get; set; }

	public DateTime? FIE_CADASTRO { get; set; }

	[StringLength(8)]
	public string FIC_MATRICULA { get; set; }
}
