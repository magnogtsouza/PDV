using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MATERIAISCONVERSAO")]
public class MATERIAISCONVERSAO
{
	[Key]
	[StringLength(14)]
	public string MAC_PRODUTO { get; set; }

	[StringLength(14)]
	public string MAC_PRODUTO_DESTINO { get; set; }

	public double? MAC_QUANTIDADE { get; set; }

	public bool? MAC_INATIVO { get; set; }

	public DateTime? MAC_ATUALIZACAO { get; set; }
}
