using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REDEPIXCAIXA")]
public class REDEPIXCAIXA
{
	[Key]
	[Column(Order = 0)]
	public Guid REC_ID_REDE { get; set; }

	public Guid? REC_LOJA_ID_REDE { get; set; }

	public byte? REC_CAIXA { get; set; }

	public string REC_CLIENTE_ID { get; set; }

	public DateTime? REC_CADASTRO { get; set; }
}
