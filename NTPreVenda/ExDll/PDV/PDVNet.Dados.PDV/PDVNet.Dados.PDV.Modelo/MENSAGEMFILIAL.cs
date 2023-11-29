using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MENSAGEMFILIAL")]
public class MENSAGEMFILIAL
{
	[Key]
	[Column(Order = 0)]
	public short MEF_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short MEF_FILIAL { get; set; }
}
