using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REMESSACARTEIRA")]
public class REMESSACARTEIRA
{
	[Key]
	[Column(Order = 0)]
	public short RCA_BANCO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(3)]
	public string RCA_CODIGO { get; set; }

	[StringLength(255)]
	public string RCA_DESCRICAO { get; set; }

	public DateTime? RCA_ATUALIZACAO { get; set; }

	public bool? RCA_INATIVO { get; set; }
}
