using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class CORES
{
	[Key]
	public short COR_CODIGO { get; set; }

	[StringLength(30)]
	public string COR_DESCRICAO { get; set; }

	public bool? COR_INATIVO2 { get; set; }

	public DateTime? COR_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string COR_MATRICULA { get; set; }

	public int? COR_BASICA { get; set; }

	[StringLength(20)]
	public string COR_CODIGO_EXTERNO { get; set; }

	[StringLength(6)]
	public string COR_RGB { get; set; }

	public virtual ICollection<MATERIAIS> MATERIAIS { get; set; }

	public CORESBASICAS ExtensaoCorBasica { get; set; }
}
