using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("PROFISSAO")]
public class PROFISSAO
{
	[Key]
	public short PRO_CODIGO { get; set; }

	[StringLength(30)]
	public string PRO_DESCRICAO { get; set; }

	public bool? PRO_INATIVO2 { get; set; }
}
