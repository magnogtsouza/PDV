using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FRANQUIACONF")]
public class FRANQUIACONF
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int FRA_FILIAL { get; set; }

	public bool? FRA_PRECO1 { get; set; }

	public bool? FRA_PRECO2 { get; set; }

	public byte? FRA_NOTA { get; set; }

	public DateTime? FRA_ATUALIZACAO { get; set; }
}
