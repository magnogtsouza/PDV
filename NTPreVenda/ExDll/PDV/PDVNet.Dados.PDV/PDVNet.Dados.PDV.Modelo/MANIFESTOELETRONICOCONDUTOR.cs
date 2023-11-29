using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MANIFESTOELETRONICOCONDUTOR")]
public class MANIFESTOELETRONICOCONDUTOR
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string MCO_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public short MCO_CONDUTOR { get; set; }

	[NotMapped]
	public CONDUTOR Condutor { get; set; }
}
