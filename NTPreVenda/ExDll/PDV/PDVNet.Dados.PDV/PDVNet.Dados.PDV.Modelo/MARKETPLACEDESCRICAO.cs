using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MARKETPLACEDESCRICAO")]
public class MARKETPLACEDESCRICAO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public byte MPD_CODIGO { get; set; }

	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	[StringLength(30)]
	public string MPD_DESCRICAO { get; set; }
}
