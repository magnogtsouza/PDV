using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAIXACODIGOEXTERNO")]
public class CAIXACODIGOEXTERNO
{
	[Key]
	[StringLength(20)]
	public string CCE_DOC { get; set; }

	[StringLength(20)]
	public string CCE_CODIGO_EXTERNO { get; set; }

	public byte? CCE_STATUS { get; set; }

	public DateTime? CCE_STATUS_ATUALIZACAO { get; set; }
}
