using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ITEMNOTAADICAO")]
public class ITEMNOTAADICAO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string INA_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public int INA_SEQ_ITEM { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte INA_SEQ_DI { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte INA_SEQ { get; set; }

	public int? INA_NUMERO { get; set; }

	[StringLength(60)]
	public string INA_CODIGO_FABRICANTE { get; set; }

	public double? INA_VALOR_DESCONTO { get; set; }
}
