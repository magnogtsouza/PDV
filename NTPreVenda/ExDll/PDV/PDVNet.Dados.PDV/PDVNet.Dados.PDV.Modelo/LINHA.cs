using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("LINHA")]
public class LINHA
{
	[Key]
	public short LIN_CODIGO { get; set; }

	[StringLength(30)]
	public string LIN_DESCRICAO { get; set; }

	public byte? LIN_REDE { get; set; }

	public bool? LIN_INATIVO2 { get; set; }

	public DateTime? LIN_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string LIN_MATRICULA { get; set; }

	public virtual ICollection<REFERENCIAS> REFERENCIAS { get; set; }
}
