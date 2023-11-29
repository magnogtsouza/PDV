using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NOTAFISCALAUXILIAR")]
public class NOTAFISCALAUXILIAR
{
	[Key]
	[StringLength(20)]
	public string NFA_DOC_NOTA { get; set; }

	[StringLength(20)]
	public string NFA_DOC_AUXILIAR { get; set; }

	public bool? NFA_TIPO { get; set; }

	public double? NFA_VALOR { get; set; }
}
