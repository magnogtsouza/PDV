using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALCOMUNICA")]
public class FILIALCOMUNICA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short FIC_ORIGEM { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short FIC_DESTINO { get; set; }

	public DateTime? FIC_CADASTRO { get; set; }

	[StringLength(8)]
	public string FIC_MATRICULA { get; set; }

	public DateTime? FIC_ATUALIZACAO { get; set; }
}
