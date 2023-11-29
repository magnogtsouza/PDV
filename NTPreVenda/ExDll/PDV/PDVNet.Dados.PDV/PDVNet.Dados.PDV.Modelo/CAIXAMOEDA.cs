using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAIXAMOEDA")]
public class CAIXAMOEDA
{
	public byte? CAM_MOEDA { get; set; }

	[Key]
	[StringLength(20)]
	public string CAM_DOC { get; set; }
}
