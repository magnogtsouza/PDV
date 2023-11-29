using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("COTAPRODUTO")]
public class COTAPRODUTO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short COP_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string COP_PRODUTO { get; set; }

	public double? COP_QTD { get; set; }

	public double? COP_VALOR { get; set; }

	public double? COP_VENDA { get; set; }

	public byte? COP_BLOQUEADO { get; set; }

	[StringLength(8)]
	public string COP_MATRICULA { get; set; }

	public DateTime? COP_ATUALIZACAO { get; set; }
}
