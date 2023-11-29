using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CATEGORIANOTICIA")]
public class CATEGORIANOTICIA
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CAT_CODIGO { get; set; }

	[StringLength(30)]
	public string CAT_DESCRICAO { get; set; }
}
