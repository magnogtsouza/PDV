using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REDEPIXLOJA")]
public class REDEPIXLOJA
{
	[Key]
	[Column(Order = 0)]
	public Guid REL_LOJA_ID_REDE { get; set; }

	[Key]
	[Column(Order = 1)]
	public Guid REL_CLIENTE_ID_REDE { get; set; }

	public int? REL_LOJA { get; set; }

	public DateTime? REL_CADASTRO { get; set; }

	public DateTime? REL_ATUALIZACAO { get; set; }

	public bool? REL_INATIVA { get; set; }

	[StringLength(8)]
	public string REL_MATRICULA { get; set; }
}
