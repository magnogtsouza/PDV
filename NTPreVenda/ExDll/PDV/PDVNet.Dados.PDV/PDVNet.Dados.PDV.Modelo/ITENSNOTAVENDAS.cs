using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ITENSNOTAVENDAS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string IVE_ITENSNOTA_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short IVE_ITENSNOTA_ITEM { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(20)]
	public string IVE_VENDAS_DOC { get; set; }

	[Key]
	[Column(Order = 3)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short IVE_VENDAS_ITEM { get; set; }
}
