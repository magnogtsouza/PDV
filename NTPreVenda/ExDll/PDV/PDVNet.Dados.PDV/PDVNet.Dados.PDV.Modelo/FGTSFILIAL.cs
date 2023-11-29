using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class FGTSFILIAL
{
	[Key]
	public short FFI_FILIAL { get; set; }

	[StringLength(100)]
	public string FFI_USUARIO { get; set; }

	[StringLength(100)]
	public string FFI_SENHA { get; set; }
}
