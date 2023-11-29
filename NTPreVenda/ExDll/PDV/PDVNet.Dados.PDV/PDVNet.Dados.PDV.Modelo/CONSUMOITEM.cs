using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONSUMOITEM")]
public class CONSUMOITEM
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string COI_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short COI_SEQ { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(14)]
	public string COI_PRODUTO { get; set; }

	public double? COI_QTD { get; set; }

	public double? COI_PRECO_CUSTO { get; set; }

	public byte? COI_TIPO { get; set; }

	[NotMapped]
	public byte? CON_TIPO { get; set; }
}
