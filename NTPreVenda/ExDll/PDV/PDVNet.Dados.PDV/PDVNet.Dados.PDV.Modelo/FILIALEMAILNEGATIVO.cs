using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALEMAILNEGATIVO")]
public class FILIALEMAILNEGATIVO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int FIN_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte FIN_CODIGO { get; set; }

	[StringLength(50)]
	public string FIN_EMAIL { get; set; }

	public byte? FIN_TIPO { get; set; }

	public DateTime? FIN_CADASTRO { get; set; }

	public DateTime? FIN_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string FIN_MATRICULA { get; set; }

	public bool? FIN_INATIVO { get; set; }
}
