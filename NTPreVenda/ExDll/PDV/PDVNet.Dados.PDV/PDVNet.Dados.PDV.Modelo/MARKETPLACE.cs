using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MARKETPLACE")]
public class MARKETPLACE
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public byte MPL_CODIGO { get; set; }

	[StringLength(30)]
	public string MPL_DESCRICAO { get; set; }

	[StringLength(14)]
	public string MPL_CNPJ { get; set; }

	[StringLength(14)]
	public string MPL_CNPJ_PAGAMENTO { get; set; }

	public DateTime? MPL_CADASTRO { get; set; }

	public DateTime? MPL_ATUALIZACAO { get; set; }

	public bool? MPL_INATIVO { get; set; }
}
