using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class DAV_ITENS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(13)]
	public string DAI_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short DAI_SEQ { get; set; }

	[StringLength(14)]
	public string DAI_PRODUTO { get; set; }

	public double? DAI_QUANTIDADE { get; set; }

	public double? DAI_PRECOTABELA { get; set; }

	public double? DAI_CUSTO1 { get; set; }

	public double? DAI_CUSTO2 { get; set; }

	public double? DAI_VALOR { get; set; }

	[StringLength(3)]
	public string DAI_SITUACAO { get; set; }

	public double? DAI_ICMS { get; set; }

	public bool? DAI_INATIVO { get; set; }

	public double? DAI_ACRESCIMO { get; set; }

	public double? DAI_DESCONTO { get; set; }

	public short? DAI_FILIAL { get; set; }

	public double? DAI_VALOR_TOTAL { get; set; }

	public string DAI_VENDEDOR { get; set; }

	public virtual ICollection<DAVITENSEPC> DAI_ITENSEPC { get; set; }
}
