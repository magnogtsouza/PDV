using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DESCRICAO")]
public class DESCRICAO
{
	public short? DES_FILIAL { get; set; }

	[StringLength(9)]
	public string DES_NOTA { get; set; }

	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int DES_SEQUENCIA { get; set; }

	[StringLength(255)]
	public string DES_DESCRICAO { get; set; }

	[StringLength(6)]
	public string DES_UNIDADE { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string DES_NOTA_DOC { get; set; }

	[StringLength(8)]
	public string DES_NCM { get; set; }
}
