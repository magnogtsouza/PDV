using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REPRESENTANTEREDE")]
public class REPRESENTANTEREDE
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short RER_REPRESENTANTE { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte RER_REDE { get; set; }
}
