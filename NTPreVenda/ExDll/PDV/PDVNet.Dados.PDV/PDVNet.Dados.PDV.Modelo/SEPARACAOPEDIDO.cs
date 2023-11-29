using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SEPARACAOPEDIDO")]
public class SEPARACAOPEDIDO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int SEP_CODIGO { get; set; }

	[StringLength(16)]
	public string SEP_CODIGON { get; set; }

	public short? SEP_FILIAL { get; set; }

	public DateTime? SEP_CADASTRO { get; set; }

	public DateTime? SEP_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string SEP_MATRICULA { get; set; }

	public bool? SEP_INATIVO { get; set; }

	public DateTime? SEP_FATURAMENTO { get; set; }

	public byte? SEP_STATUS { get; set; }

	public byte? SEP_VOLUMES { get; set; }

	public byte? SEP_CONFERIDA { get; set; }

	public byte? SEP_TABELA { get; set; }

	public byte? SEP_ENDERECO { get; set; }
}
