using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REMESSAINSTRUCAO")]
public class REMESSAINSTRUCAO
{
	[Key]
	[Column(Order = 0)]
	public short REI_BANCO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(2)]
	public string REI_CODIGO { get; set; }

	[StringLength(255)]
	public string REI_DESCRICAO { get; set; }

	public DateTime? REI_ATUALIZACAO { get; set; }
}
