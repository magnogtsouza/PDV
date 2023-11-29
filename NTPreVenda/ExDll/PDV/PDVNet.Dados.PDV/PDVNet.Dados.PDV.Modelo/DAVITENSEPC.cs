using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class DAVITENSEPC
{
	[Key]
	[Column(Order = 0)]
	[StringLength(13)]
	public string DIE_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short DIE_FILIAL { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short DIE_SEQ { get; set; }

	[Key]
	[Column(Order = 3)]
	[StringLength(24)]
	public string DIE_EPC { get; set; }
}
