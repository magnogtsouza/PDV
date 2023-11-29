using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("BORDERO")]
public class BORDERO
{
	[Key]
	public int BOR_BORDERO { get; set; }

	[StringLength(3)]
	public string BOR_CUSTODIA { get; set; }

	public DateTime? BOR_D_DESCONTO { get; set; }

	public double? BOR_TAXAM { get; set; }

	public byte? BOR_DIAS { get; set; }

	public double? BOR_IOF { get; set; }

	public DateTime? BOR_DEPOSITO { get; set; }

	public DateTime? BOR_CADASTRO { get; set; }

	public DateTime? BOR_ALTERADO { get; set; }

	[StringLength(8)]
	public string BOR_USUARIO { get; set; }

	[StringLength(6)]
	public string BOR_FORNECEDOR { get; set; }

	public double? BOR_VALOR { get; set; }

	public int? BOR_EXTRATO_C { get; set; }

	public int? BOR_EXTRATO_D { get; set; }

	public bool? BOR_EXCLUIDO2 { get; set; }
}
