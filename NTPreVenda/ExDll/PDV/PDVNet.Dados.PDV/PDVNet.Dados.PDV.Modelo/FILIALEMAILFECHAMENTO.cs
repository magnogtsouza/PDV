using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALEMAILFECHAMENTO")]
public class FILIALEMAILFECHAMENTO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int FIF_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte FIF_CODIGO { get; set; }

	[StringLength(50)]
	public string FIF_EMAIL { get; set; }

	public byte? FIF_TIPO { get; set; }

	public bool? FIF_INATIVO { get; set; }

	public DateTime? FIF_CADASTRO { get; set; }

	public DateTime? FIF_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string FIF_MATRICULA { get; set; }
}
