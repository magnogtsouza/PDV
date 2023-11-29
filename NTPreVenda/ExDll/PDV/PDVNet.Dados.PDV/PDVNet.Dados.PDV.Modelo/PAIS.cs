using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class PAIS
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short PAI_CODIGO { get; set; }

	[StringLength(60)]
	public string PAI_NOME { get; set; }

	public bool? PAI_INATIVO { get; set; }
}
