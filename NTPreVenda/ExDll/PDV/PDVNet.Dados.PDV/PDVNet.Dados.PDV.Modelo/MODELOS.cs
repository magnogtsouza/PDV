using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class MODELOS
{
	[Key]
	public short MOD_CODIGO { get; set; }

	[StringLength(30)]
	public string MOD_DESCRICAO { get; set; }

	public bool? MOD_INATIVO2 { get; set; }

	public DateTime? MOD_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string MOD_MATRICULA { get; set; }

	public virtual ICollection<REFERENCIAS> REFERENCIAS { get; set; }
}
