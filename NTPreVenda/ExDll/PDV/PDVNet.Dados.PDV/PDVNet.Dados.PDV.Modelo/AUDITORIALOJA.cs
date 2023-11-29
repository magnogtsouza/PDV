using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("AUDITORIALOJA")]
public class AUDITORIALOJA
{
	[Column(Order = 0)]
	[Key]
	public byte ALO_AUDITORIA { get; set; }

	[Column(Order = 1)]
	[Key]
	public short ALO_LOJA { get; set; }

	public DateTime? ALO_ATUALIZACAO { get; set; }

	public bool? ALO_STATUS { get; set; }
}
