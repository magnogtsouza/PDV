using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class TAREFASDIAS
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short TAD_CODIGO { get; set; }

	public byte? TAD_DIA { get; set; }

	public DateTime? TAD_HORARIO { get; set; }
}
