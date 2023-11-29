using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MANIFESTOELETRONICOPERCURSO")]
public class MANIFESTOELETRONICOPERCURSO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string MEP_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte MEP_UF { get; set; }

	public byte? MEP_SEQ { get; set; }

	[NotMapped]
	public string Sigla { get; set; }
}
