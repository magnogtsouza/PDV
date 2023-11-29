using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SALDOSDOCUMENTO")]
public class SALDOSDOCUMENTO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string SAD_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte SAD_TIPO { get; set; }

	public bool? SAD_INATIVO { get; set; }
}
