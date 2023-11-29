using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("WMSENDERECO")]
public class WMSENDERECO
{
	[Key]
	[Column(Order = 0)]
	public int WME_CODIGO { get; set; }

	[StringLength(20)]
	public string WME_DESCRICAO { get; set; }

	public bool WME_INATIVO { get; set; }

	public DateTime? WME_CADASTRO { get; set; }

	public DateTime? WME_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string WME_MATRICULA { get; set; }

	[NotMapped]
	public string Caixa { get; set; }
}
