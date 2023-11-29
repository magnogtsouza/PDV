using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("APROVEITAMENTO")]
public class APROVEITAMENTO
{
	[Key]
	[Column(Order = 0)]
	public DateTime APR_DATA { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int APR_FILIAL { get; set; }

	[StringLength(8)]
	public string APR_VENDEDOR { get; set; }

	public short? APR_VENDAS { get; set; }

	[StringLength(8)]
	public string APR_MATRICULA { get; set; }
}
