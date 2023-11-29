using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SINCRONIZACAOMANUALFILIAL")]
public class SINCRONIZACAOMANUALFILIAL
{
	[Key]
	[Column(Order = 0)]
	public short SMF_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short SMF_FILIAL { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte SMF_CAIXA { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte SMF_NEGOCIO { get; set; }

	public bool? SMF_REALIZADA { get; set; }
}
