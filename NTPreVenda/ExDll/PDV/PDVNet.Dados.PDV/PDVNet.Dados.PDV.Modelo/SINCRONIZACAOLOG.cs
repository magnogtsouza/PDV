using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SINCRONIZACAOLOG")]
public class SINCRONIZACAOLOG
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int SIL_SEQ { get; set; }

	public bool? SIL_MANUAL { get; set; }

	public DateTime? SIL_DATA_ESPECIFICA { get; set; }

	public bool? SIL_INTEGRAL { get; set; }

	public DateTime? SIL_INICIO { get; set; }

	public DateTime? SIL_FINAL { get; set; }

	public bool? SIL_INTERROMPIDO { get; set; }

	public bool? SIL_ERRO { get; set; }

	[NotMapped]
	public List<SINCRONIZACAOLOGITEM> ItensTabelas { get; set; }
}
