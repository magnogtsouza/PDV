using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CLIENTESBLOQUEADO")]
public class CLIENTESBLOQUEADO
{
	[Key]
	[StringLength(16)]
	public string CLB_CODIGON { get; set; }

	public byte? CLB_STATUS { get; set; }

	public DateTime? CLB_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CLB_MATRICULA { get; set; }
}
