using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class WMSTIPO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int WMT_CODIGO { get; set; }

	[StringLength(20)]
	public string WMT_DESCRICAO { get; set; }

	[StringLength(3)]
	public string WMT_PREFIXO { get; set; }

	public bool? WMT_INATIVO { get; set; }

	public byte? WMT_ORDEM { get; set; }

	public DateTime? WMT_CADASTRO { get; set; }

	public DateTime? WMT_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string WMT_MATRICULA { get; set; }
}
