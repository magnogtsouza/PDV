using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SINCRONIZACAOMANUAL")]
public class SINCRONIZACAOMANUAL
{
	[Key]
	[Column(Order = 0)]
	public short SIM_CODIGO { get; set; }

	public DateTime? SIM_DATA_ESPECIFICA { get; set; }

	public bool? SIM_INTEGRAL { get; set; }

	public DateTime? SIM_CADASTRO { get; set; }

	[StringLength(8)]
	public string SIM_MATRICULA { get; set; }

	[NotMapped]
	public List<SINCRONIZACAOMANUALFILIAL> NegocioFilial { get; set; }
}
