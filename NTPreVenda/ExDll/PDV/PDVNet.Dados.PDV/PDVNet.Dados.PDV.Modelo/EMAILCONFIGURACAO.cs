using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class EMAILCONFIGURACAO
{
	[Key]
	public short ECO_CODIGO { get; set; }

	[StringLength(100)]
	public string ECO_DESCRICAO { get; set; }

	[StringLength(100)]
	public string ECO_NOME { get; set; }

	[StringLength(100)]
	public string ECO_EMAIL { get; set; }

	[StringLength(100)]
	public string ECO_SAIDA_SERVIDOR { get; set; }

	public int? ECO_SAIDA_PORTA { get; set; }

	public byte? ECO_SAIDA_SSL { get; set; }

	[StringLength(100)]
	public string ECO_USUARIO { get; set; }

	[StringLength(100)]
	public string ECO_SENHA { get; set; }

	public bool? ECO_AUTENTICACAO_SEGURA { get; set; }

	public DateTime? ECO_CADASTRO { get; set; }

	public DateTime? ECO_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string ECO_MATRICULA { get; set; }

	public bool? ECO_INATIVO { get; set; }

	public virtual ICollection<EMAILCONFIGURACAOFILIAL> EMAILCONFIGURACAOFILIAL { get; set; }

	public virtual ICollection<EMAILCONFIGURACAOFUNCAO> EMAILCONFIGURACAOFUNCAO { get; set; }
}
