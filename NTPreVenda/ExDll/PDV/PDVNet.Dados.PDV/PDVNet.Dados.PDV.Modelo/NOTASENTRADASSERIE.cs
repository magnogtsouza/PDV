using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NOTASENTRADASSERIE")]
public class NOTASENTRADASSERIE
{
	[Key]
	[Column(Order = 0)]
	[StringLength(6)]
	public string NOS_NOTA { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(6)]
	public string NOS_FORNECEDOR { get; set; }

	[Key]
	[Column(Order = 2)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int NOS_FILIAL { get; set; }

	[Key]
	[Column(Order = 3)]
	[StringLength(14)]
	public string NOS_PRODUTO { get; set; }

	[Key]
	[Column(Order = 4)]
	[StringLength(20)]
	public string NOS_SERIE { get; set; }
}
