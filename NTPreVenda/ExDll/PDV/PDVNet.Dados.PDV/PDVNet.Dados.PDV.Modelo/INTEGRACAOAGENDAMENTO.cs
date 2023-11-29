using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOAGENDAMENTO
{
	[Key]
	[Column(Order = 0)]
	public DateTime IAG_HORARIO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte IAG_CONFIGURACAO { get; set; }

	public byte? IAG_ORDEM { get; set; }
}
