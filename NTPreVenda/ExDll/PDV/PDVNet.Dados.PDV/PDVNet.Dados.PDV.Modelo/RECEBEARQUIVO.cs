using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("RECEBEARQUIVO")]
public class RECEBEARQUIVO
{
	public short? REC_FILIAL { get; set; }

	public byte REC_TIPO { get; set; }

	public DateTime? REC_DATA_RECEBIMENTO { get; set; }

	public DateTime? REC_DATA_ENVIO { get; set; }

	public DateTime? REC_DATA1 { get; set; }

	public DateTime? REC_DATA2 { get; set; }

	[StringLength(8)]
	public string REC_MATRICULA { get; set; }

	[StringLength(255)]
	public string REC_DADOS { get; set; }

	[Key]
	[StringLength(20)]
	public string REC_DOC { get; set; }

	public DateTime? REC_VERSAO { get; set; }

	public int? REC_REGISTROS { get; set; }
}
