using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOLUXOTTICA
{
	[Key]
	[Column(Order = 0)]
	public short INL_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short INL_FILIAL { get; set; }

	public bool? INL_MANUAL { get; set; }

	[StringLength(10)]
	public string INL_DOCUMENTO { get; set; }

	public bool? INL_ENVIADO { get; set; }

	public DateTime? INL_MOVIMENTO { get; set; }

	public DateTime? INL_CADASTRO { get; set; }

	[StringLength(8)]
	public string INL_MATRICULA { get; set; }

	public DateTime? INL_ATUALIZACAO { get; set; }

	public bool? INL_INATIVO { get; set; }

	[NotMapped]
	public string ExtensaoUsuarioNome { get; set; }

	[NotMapped]
	public List<INTEGRACAOLUXOTTICAITENS> Itens { get; set; }
}
