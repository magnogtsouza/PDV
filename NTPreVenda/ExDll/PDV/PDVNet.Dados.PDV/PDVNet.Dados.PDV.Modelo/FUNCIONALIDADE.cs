using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FUNCIONALIDADE")]
public class FUNCIONALIDADE
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short FUN_CODIGO { get; set; }

	public bool? FUN_ATIVO { get; set; }
}
