using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOFILIAL
{
	[Key]
	[Column(Order = 0)]
	public byte IFI_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(50)]
	public string IFI_ID_PLATAFORMA { get; set; }

	public short? IFI_FILIAL_PDV { get; set; }
}
