using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NOTAFISCALSERVICOITEM")]
public class NOTAFISCALSERVICOITEM
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public string NOI_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte? NOI_SEQ { get; set; }

	[StringLength(14)]
	public string NOI_SERVICO { get; set; }

	public int NOI_QUANTIDADE { get; set; }

	public double? NOI_VALOR { get; set; }

	public double? NOI_COFINS_ALIQUOTA { get; set; }

	public double? NOI_COFINS_VALOR { get; set; }

	public double? NOI_PIS_ALIQUOTA { get; set; }

	public double? NOI_PIS_VALOR { get; set; }

	public double? NOI_CSLL_ALIQUOTA { get; set; }

	public double? NOI_CSLL_VALOR { get; set; }

	public double? NOI_IRPJ_ALIQUOTA { get; set; }

	public double? NOI_IRPJ_VALOR { get; set; }
}
