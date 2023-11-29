using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ITIFILIAL
{
	[Key]
	[Column(Order = 0)]
	public short ITF_FILIAL { get; set; }

	public byte? ITF_CONTRATO { get; set; }

	public bool? ITF_INATIVO { get; set; }

	public DateTime? ITF_CADASTRO { get; set; }

	[StringLength(8)]
	public string ITF_MATRICULA { get; set; }

	public DateTime? ITF_ATUALIZACAO { get; set; }
}
