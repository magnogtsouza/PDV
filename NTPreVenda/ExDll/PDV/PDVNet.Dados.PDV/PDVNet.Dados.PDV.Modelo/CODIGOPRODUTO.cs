using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CODIGOPRODUTO")]
public class CODIGOPRODUTO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string COD_CODIGO { get; set; }

	[StringLength(14)]
	public string COD_ORIGINAL { get; set; }

	public bool? COD_ATIVO { get; set; }

	public DateTime? COD_CADASTRO { get; set; }

	[StringLength(8)]
	public string COD_MATRICULA { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte COD_REDE { get; set; }

	public DateTime? COD_ATUALIZACAO { get; set; }
}
