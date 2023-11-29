using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class EMAILCONFIGURACAOFUNCAO
{
	[Key]
	[Column(Order = 0)]
	public short EFU_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte EFU_FUNCAO { get; set; }
}
