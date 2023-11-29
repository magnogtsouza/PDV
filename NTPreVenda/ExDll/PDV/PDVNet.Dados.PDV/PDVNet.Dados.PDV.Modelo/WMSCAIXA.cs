using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class WMSCAIXA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int WMC_CODIGO { get; set; }

	[StringLength(6)]
	public string WMC_DESCRICAO { get; set; }

	public bool? WMC_INATIVO { get; set; }

	public DateTime? WMC_CADASTRO { get; set; }

	public DateTime? WMC_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string WMC_MATRICULA { get; set; }

	[NotMapped]
	public string ExtensaoUsuarioNome { get; set; }
}
