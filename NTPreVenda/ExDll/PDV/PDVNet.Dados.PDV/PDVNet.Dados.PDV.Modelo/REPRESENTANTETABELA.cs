using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REPRESENTANTETABELA")]
public class REPRESENTANTETABELA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short RET_REPRESENTANTE { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte RET_TABELA { get; set; }
}
