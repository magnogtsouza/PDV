using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("PRECO")]
public class PRECO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string PRE_PRODUTO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte PRE_TABELA { get; set; }

	public double? PRE_PRECO1 { get; set; }

	public double? PRE_PRECO2 { get; set; }

	public DateTime? PRE_CADASTRO { get; set; }

	public DateTime? PRE_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string PRE_MATRICULA { get; set; }

	public int? PRE_ASSINA { get; set; }

	public virtual MATERIAIS MATERIAIS { get; set; }
}
