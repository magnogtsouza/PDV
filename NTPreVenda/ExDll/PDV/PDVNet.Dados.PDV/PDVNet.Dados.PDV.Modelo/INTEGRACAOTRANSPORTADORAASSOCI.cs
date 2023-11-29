using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOTRANSPORTADORAASSOCIACAO
{
	[Key]
	[Column(Order = 0)]
	public byte ITA_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(50)]
	public string ITA_CODIGO_PLATAFORMA { get; set; }

	public short? ITA_TRANSPORTADORA_PDV { get; set; }
}
