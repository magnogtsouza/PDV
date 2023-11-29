using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("WMSLOCAL")]
public class WMSLOCAL
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int WML_CODIGO { get; set; }

	public int WML_ENDERECO { get; set; }

	public int WML_CAIXA { get; set; }
}
