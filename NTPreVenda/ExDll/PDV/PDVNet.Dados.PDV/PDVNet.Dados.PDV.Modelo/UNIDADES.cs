using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class UNIDADES
{
	[Key]
	public byte? UNI_CODIGO { get; set; }

	[StringLength(20)]
	public string UNI_DESCRICAO { get; set; }

	[StringLength(4)]
	public string UNI_PREFIXO { get; set; }

	public bool? UNI_INATIVO { get; set; }

	public virtual ICollection<REFERENCIAS> REFERENCIAS { get; set; }
}
