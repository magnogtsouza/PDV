using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class EMAILCONFIGURACAOFILIAL
{
	[Key]
	[Column(Order = 0)]
	public short EFI_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short EFI_FILIAL { get; set; }
}
