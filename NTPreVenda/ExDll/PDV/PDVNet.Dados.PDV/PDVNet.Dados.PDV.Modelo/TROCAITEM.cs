using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TROCAITEM")]
public class TROCAITEM
{
	[Key]
	[StringLength(20)]
	public string TRI_SAIDA_DOC { get; set; }

	[Key]
	public int TRI_SAIDA_ITEM { get; set; }

	[StringLength(55)]
	public string TRI_SAIDA_CHAVE { get; set; }

	[Key]
	[StringLength(20)]
	public string TRI_ENTRADA_DOC { get; set; }

	[Key]
	public int TRI_ENTRADA_ITEM { get; set; }

	public float TRI_ENTRADA_QUANTIDADE { get; set; }
}
