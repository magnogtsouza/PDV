using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CLIENTESFIDELIDADE")]
public class CLIENTESFIDELIDADE
{
	[Key]
	[StringLength(10)]
	public string CLF_CARTAO { get; set; }

	public byte? CLF_REDE { get; set; }

	[StringLength(16)]
	public string CLF_CODIGON { get; set; }

	public DateTime? CLF_CADASTRO { get; set; }

	public DateTime? CLF_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CLF_MATRICULA { get; set; }

	public bool? CLF_INATIVO { get; set; }
}
