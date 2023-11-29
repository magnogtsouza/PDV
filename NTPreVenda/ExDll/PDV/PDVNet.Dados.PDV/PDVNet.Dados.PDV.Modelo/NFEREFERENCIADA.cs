using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NFEREFERENCIADA")]
public class NFEREFERENCIADA
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string NRE_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short NRE_SEQ { get; set; }

	[StringLength(55)]
	public string NRE_CHAVE { get; set; }
}
