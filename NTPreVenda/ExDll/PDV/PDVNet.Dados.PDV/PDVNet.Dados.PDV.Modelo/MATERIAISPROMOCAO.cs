using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MATERIAISPROMOCAO")]
public class MATERIAISPROMOCAO
{
	[Key]
	[Column(Order = 0)]
	public short PRO_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string PRO_PRODUTO { get; set; }

	public double? PRO_VALOR { get; set; }

	public double? PRO_VALOR_ANTERIOR { get; set; }

	public virtual MATERIAIS MATERIAIS { get; set; }

	public virtual REGISTROPROMOCAO REGISTROPROMOCAO { get; set; }
}
