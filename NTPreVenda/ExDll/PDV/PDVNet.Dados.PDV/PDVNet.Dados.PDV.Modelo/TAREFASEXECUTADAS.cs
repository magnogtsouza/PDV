using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class TAREFASEXECUTADAS
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short TAE_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public DateTime TAE_DATA_TAREFA { get; set; }

	[Key]
	[Column(Order = 2)]
	public DateTime TAE_HORARIO_TAREFA { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte TAE_TIPO { get; set; }

	public DateTime? TAE_DATA_EXECUTADO { get; set; }

	public DateTime? TAE_HORARIO_EXECUTADO { get; set; }
}
