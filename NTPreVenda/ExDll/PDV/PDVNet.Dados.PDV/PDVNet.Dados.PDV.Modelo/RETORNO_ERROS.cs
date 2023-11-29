using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class RETORNO_ERROS
{
	[Key]
	[Column(Order = 0)]
	public short REE_BANCO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(3)]
	public string REE_CODIGO { get; set; }

	[StringLength(255)]
	public string REE_DESCRICAO { get; set; }

	public DateTime? REE_ATUALIZACAO { get; set; }
}
