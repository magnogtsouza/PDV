using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REMANEJA")]
public class REMANEJA
{
	[Key]
	[StringLength(20)]
	public string REM_DOC { get; set; }

	[StringLength(8)]
	public string REM_MATRICULA { get; set; }

	public DateTime? REM_ATUALIZACAO { get; set; }

	public short? REM_ORIGEM { get; set; }

	public short? REM_DESTINO { get; set; }

	[StringLength(14)]
	public string REM_PRODUTO { get; set; }

	public double? REM_QTD_PEDIDA { get; set; }

	public double? REM_QTD_ENVIADA { get; set; }

	public bool? REM_INATIVO { get; set; }

	public bool? REM_RESOLVIDO { get; set; }
}
