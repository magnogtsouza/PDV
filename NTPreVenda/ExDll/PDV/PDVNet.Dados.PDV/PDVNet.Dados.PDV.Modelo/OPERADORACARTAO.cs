using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("OPERADORACARTAO")]
public class OPERADORACARTAO
{
	[Key]
	[Column(Order = 0)]
	public byte OPC_CODIGO { get; set; }

	[StringLength(30)]
	public string OPC_DESCRICAO { get; set; }

	public bool? OPC_INATIVO { get; set; }

	public DateTime? OPC_ATUALIZACAO { get; set; }
}
