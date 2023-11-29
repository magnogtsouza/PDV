using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONSIGNACAO")]
public class CONSIGNACAO
{
	[StringLength(8)]
	public string CON_CODIGO { get; set; }

	public DateTime? CON_DATA { get; set; }

	[StringLength(16)]
	public string CON_CODIGON { get; set; }

	public short? CON_FILIAL { get; set; }

	public byte? CON_TABELA { get; set; }

	[StringLength(8)]
	public string CON_VENDEDOR { get; set; }

	public DateTime? CON_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CON_MATRICULA { get; set; }

	public DateTime? CON_CADASTRO { get; set; }

	[StringLength(255)]
	public string CON_OBS { get; set; }

	[Key]
	[StringLength(20)]
	public string CON_DOC { get; set; }

	[StringLength(8)]
	public string CON_DECORADOR { get; set; }
}
