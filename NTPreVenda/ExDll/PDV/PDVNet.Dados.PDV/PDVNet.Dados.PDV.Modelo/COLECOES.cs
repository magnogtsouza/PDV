using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class COLECOES
{
	[Key]
	public short COL_CODIGO { get; set; }

	[StringLength(30)]
	public string COL_DESCRICAO { get; set; }

	public byte? COL_REDE { get; set; }

	public bool? COL_INATIVO2 { get; set; }

	public DateTime? COL_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string COL_MATRICULA { get; set; }

	public virtual ICollection<REFERENCIAS> REFERENCIAS { get; set; }
}
