using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("EMBALAGEM")]
public class EMBALAGEM
{
	[Key]
	[StringLength(3)]
	public string EMB_CODIGO { get; set; }

	[StringLength(30)]
	public string EMB_DESCRICAO { get; set; }

	public DateTime? EMB_CADASTRO { get; set; }

	[StringLength(8)]
	public string EMB_MATRICULA { get; set; }

	public bool? EMB_INATIVO { get; set; }

	public DateTime? EMB_ATUALIZACAO { get; set; }
}
