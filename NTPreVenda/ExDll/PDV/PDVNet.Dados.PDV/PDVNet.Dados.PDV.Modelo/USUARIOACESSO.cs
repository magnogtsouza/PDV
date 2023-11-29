using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using PDVNet.Util;

namespace PDVNet.Dados.PDV.Modelo;

[Table("USUARIOACESSO")]
public class USUARIOACESSO
{
	//public enumAcessoUsuario AcessoEnumerado { get; set; }

	//public enumTipoAcessoBasico TipoAcesso { get; set; }

	[Key]
	[Column(Order = 0)]
	[StringLength(8)]
	public string UAC_MATRICULA { get; set; }

	[Key]
	[Column(Order = 1)]
	public short? UAC_FUNCIONALIDADE { get; set; }

	[StringLength(40)]
	public string UAC_VALOR { get; set; }

	[NotMapped]
	public bool AcessoPermitido { get; set; }
}
