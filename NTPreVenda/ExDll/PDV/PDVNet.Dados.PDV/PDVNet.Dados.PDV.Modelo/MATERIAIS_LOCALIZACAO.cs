using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class MATERIAIS_LOCALIZACAO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string MAL_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short MAL_FILIAL { get; set; }

	[StringLength(20)]
	public string MAL_ENDERECAMENTO { get; set; }
}
