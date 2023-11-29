using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SEPARAVENDA")]
public class SEPARAVENDA
{
	[StringLength(6)]
	public string SEV_CODIGO { get; set; }

	public DateTime? SEV_CADASTRO { get; set; }

	public DateTime? SEV_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string SEV_MATRICULA { get; set; }

	public bool? SEV_INATIVO { get; set; }

	public byte? SEV_FATURADO { get; set; }

	public short? SEV_FILIAL { get; set; }

	public short? SEV_FILIAL_ESTOQUE { get; set; }

	[Key]
	[StringLength(20)]
	public string SEV_SEPARACAO_DOC { get; set; }

	[NotMapped]
	public List<ITENSSEPARAVENDA> ExtensaoItens { get; set; }
}
