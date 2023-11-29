using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOCAMPOEXPORTACAO
{
	[Key]
	[Column(Order = 0)]
	public byte ICE_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short ICE_CAMPO { get; set; }

	public bool? ICE_EXPORTAR { get; set; }

	public short? ICE_CAMPO_ADICIONAL { get; set; }
}
