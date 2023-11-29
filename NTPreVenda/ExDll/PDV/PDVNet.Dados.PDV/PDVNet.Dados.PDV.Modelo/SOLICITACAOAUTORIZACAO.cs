using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SOLICITACAOAUTORIZACAO")]
public class SOLICITACAOAUTORIZACAO
{
	[Key]
	public Guid? SAU_ID { get; set; }

	public short? SAU_FILIAL { get; set; }

	[StringLength(8)]
	public string SAU_MATRICULA_SOLICITANTE { get; set; }

	[StringLength(8)]
	public string SAU_MATRICULA_AUTORIZADOR { get; set; }

	public short? SAU_ACESSO { get; set; }

	public double? SAU_VALOR { get; set; }

	[StringLength(20)]
	public string SAU_DOC { get; set; }

	public DateTime? SAU_CADASTRO { get; set; }

	public DateTime? SAU_ATUALIZACAO { get; set; }

	public byte? SAU_STATUS { get; set; }
}
