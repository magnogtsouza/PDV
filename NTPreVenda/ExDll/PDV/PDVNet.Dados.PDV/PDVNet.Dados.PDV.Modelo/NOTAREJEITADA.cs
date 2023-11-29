using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NOTAREJEITADA")]
public class NOTAREJEITADA
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string NOR_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short NOR_SEQ { get; set; }

	[StringLength(255)]
	public string NOR_DESCRICAO { get; set; }

	public DateTime? NOR_DATA { get; set; }

	[StringLength(8)]
	public string NOR_MATRICULA { get; set; }

	public short NOR_REJEICAO { get; set; }
}
