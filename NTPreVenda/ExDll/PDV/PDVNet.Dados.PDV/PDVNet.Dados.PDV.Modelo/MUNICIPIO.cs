using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MUNICIPIO")]
public class MUNICIPIO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int MUN_CODIGO { get; set; }

	[StringLength(40)]
	public string MUN_NOME { get; set; }

	public byte? MUN_UF { get; set; }
}
