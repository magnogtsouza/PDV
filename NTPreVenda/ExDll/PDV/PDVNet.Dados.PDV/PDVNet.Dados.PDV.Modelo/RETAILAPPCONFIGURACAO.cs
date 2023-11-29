using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class RETAILAPPCONFIGURACAO
{
	[Key]
	public byte RAC_CODIGO { get; set; }

	[StringLength(100)]
	public string RAC_USUARIO { get; set; }

	[StringLength(100)]
	public string RAC_SENHA { get; set; }

	public TimeSpan? RAC_INTERVALO { get; set; }

	public DateTime? RAC_DATA_MINIMA { get; set; }

	public DateTime? RAC_LOJAS_ULTIMA_EXPORTACAO { get; set; }

	public DateTime? RAC_VENDEDORES_ULTIMA_EXPORTACAO { get; set; }
}
