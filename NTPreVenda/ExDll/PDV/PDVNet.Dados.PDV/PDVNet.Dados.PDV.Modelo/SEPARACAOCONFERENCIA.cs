using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SEPARACAOCONFERENCIA")]
public class SEPARACAOCONFERENCIA
{
	[Key]
	[Column(Order = 0)]
	public short SEC_CODIGO { get; set; }

	[StringLength(20)]
	public string SEC_SEPARACAO_DOC { get; set; }

	[StringLength(20)]
	public string SEC_DOC_VENDA { get; set; }

	[StringLength(8)]
	public string SEC_MATRICULA { get; set; }

	public DateTime? SEC_ATUALIZACAO { get; set; }

	public short? SEC_STATUS { get; set; }
}
