using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALCOMANDO")]
public class FILIALCOMANDO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short FIC_CODIGO { get; set; }

	public short? FIC_FILIAL { get; set; }

	[Column(TypeName = "ntext")]
	public string FIC_COMANDO { get; set; }

	public DateTime? FIC_CADASTRO { get; set; }

	public DateTime? FIC_ATUALIZACAO { get; set; }

	public byte? FIC_STATUS { get; set; }

	[StringLength(8)]
	public string FIC_MATRICULA { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte FIC_ORIGEM { get; set; }
}
