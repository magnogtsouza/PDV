using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TRANSPORTADORASERVICO")]
public class TRANSPORTADORASERVICO
{
	[Key]
	[Column(Order = 0)]
	public short TRS_TRANSPORTADORA { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte TRS_SEQ { get; set; }

	[StringLength(10)]
	public string TRS_CODIGO_EXTERNO { get; set; }

	[StringLength(30)]
	public string TRS_DESCRICAO { get; set; }

	public bool? TRS_INATIVO { get; set; }
}
