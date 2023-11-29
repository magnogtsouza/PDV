using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using PDVNet.Util;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CATEGORIA")]
public class CATEGORIA
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CAT_CODIGO { get; set; }

	[StringLength(100)]
	public string CAT_DESCRICAO { get; set; }

	public short? CAT_PAI { get; set; }

	public byte? CAT_ORDEM { get; set; }

	public bool? CAT_INATIVO { get; set; }

	[StringLength(8)]
	public string CAT_MATRICULA { get; set; }

	public DateTime? CAT_CADASTRO { get; set; }

	public DateTime? CAT_ATUALIZACAO { get; set; }

	[NotMapped]
	public virtual ICollection<CATEGORIA> Filhos { get; set; }

	public override string ToString()
	{
		return $"{CAT_CODIGO} - {CAT_DESCRICAO}";
		//return CAT_CODIGO.ReceberString() + " - " + CAT_DESCRICAO.ReceberString();
	}
}
