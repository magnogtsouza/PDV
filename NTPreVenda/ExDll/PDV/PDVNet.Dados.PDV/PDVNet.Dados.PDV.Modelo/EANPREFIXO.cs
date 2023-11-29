using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("EANPREFIXO")]
public class EANPREFIXO
{
	[Key]
	[Column(Order = 0)]
	public short EAP_PREFIXO { get; set; }

	public short? EAP_PAIS { get; set; }

	public bool? EAP_INATIVO { get; set; }

	public DateTime? EAP_ATUALIZACAO { get; set; }
}
