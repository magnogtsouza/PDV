using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MATERIAISCORSEQ")]
public class MATERIAISCORSEQ
{
	[Key]
	[Column(Order = 0)]
	public byte MAC_REDE { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(12)]
	public string MAC_REFERENCIA { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int MAC_SEQ { get; set; }

	[StringLength(30)]
	public string MAC_REFERENCIA_FORNECEDOR { get; set; }
}
