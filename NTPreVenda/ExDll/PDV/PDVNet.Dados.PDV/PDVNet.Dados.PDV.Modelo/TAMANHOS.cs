using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class TAMANHOS
{
	[Key]
	public short TAM_CODIGO { get; set; }

	public byte? TAM_GRADE { get; set; }

	[StringLength(20)]
	public string TAM_TAMANHO { get; set; }

	public DateTime? TAM_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string TAM_MATRICULA { get; set; }

	public short? TAM_ORDEM { get; set; }

	public bool? TAM_INATIVO { get; set; }

	public virtual ICollection<MATERIAIS> MATERIAIS { get; set; }
}
