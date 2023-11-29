using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REFERENCIACATEGORIA")]
public class REFERENCIACATEGORIA
{
	[Key]
	[Column(Order = 0)]
	public byte REC_REDE { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(12)]
	public string REC_REFERENCIA { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short REC_CATEGORIA { get; set; }
}
