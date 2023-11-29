using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TIPOPESSOA")]
public class TIPOPESSOA
{
	[Key]
	[Column(Order = 0)]
	public short TPE_CODIGO { get; set; }

	[StringLength(50)]
	public string TPE_DESCRICAO { get; set; }

	public DateTime? TPE_ATUALIZACAO { get; set; }

	public bool? TPE_INATIVO { get; set; }
}
