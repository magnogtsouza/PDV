using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TABELAPRECO")]
public class TABELAPRECO
{
	[Key]
	public byte TAB_CODIGO { get; set; }

	[StringLength(40)]
	public string TAB_DESCRICAO { get; set; }

	public byte? TAB_TIPO { get; set; }

	public byte? TAB_COMUNICA { get; set; }

	public bool? TAB_INATIVO { get; set; }

	public DateTime? TAB_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string TAB_MATRICULA { get; set; }

	[StringLength(40)]
	public string TAB_DESCRICAO_FRANQUIA { get; set; }

	public byte? TAB_ETIQUETA { get; set; }

	public byte? TAB_EXIBE_LOJA { get; set; }

	public byte? TAB_TABELA_MARGEM { get; set; }

	public byte? TAB_D_PRECO { get; set; }

	public byte? TAB_PADRAO { get; set; }

	public byte? TAB_CONTABIL { get; set; }
}
