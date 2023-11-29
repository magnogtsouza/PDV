using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DOCUMENTOSNAOFISCAL")]
public class DOCUMENTOSNAOFISCAL
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short DOC_FILIAL { get; set; }

	public byte? DOC_CAIXA { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte DOC_IMPRESSORA { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(6)]
	public string DOC_COO { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte DOC_SEQ { get; set; }

	[StringLength(6)]
	public string DOC_GNF { get; set; }

	[StringLength(6)]
	public string DOC_GRG { get; set; }

	[StringLength(4)]
	public string DOC_CDC { get; set; }

	[StringLength(2)]
	public string DOC_DENOMINACAO { get; set; }

	public DateTime? DOC_DATA { get; set; }

	[StringLength(8)]
	public string DOC_HORA { get; set; }

	public int? DOC_ASSINA { get; set; }

	[StringLength(20)]
	public string DOC_SERIAL { get; set; }

	[StringLength(20)]
	public string DOC_CAI_DOC { get; set; }
}
