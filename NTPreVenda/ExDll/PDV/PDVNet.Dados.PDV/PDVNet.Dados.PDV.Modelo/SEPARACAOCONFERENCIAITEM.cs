using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SEPARACAOCONFERENCIAITEM")]
public class SEPARACAOCONFERENCIAITEM
{
	[Key]
	[Column(Order = 0)]
	public short SCI_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short SCI_ITEM { get; set; }

	public double? SCI_QUANTIDADE { get; set; }

	public DateTime? SCI_ATUALIZACAO { get; set; }
}
