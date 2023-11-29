using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("INTEGRACAOCATEGORIA")]
public class INTEGRACAOCATEGORIA
{
	[Key]
	public short? ICA_CONFIGURACAO { get; set; }

	[Key]
	public short? ICA_PDV_CODIGO { get; set; }

	[StringLength(10)]
	public string ICA_PLATAFORMA_ID { get; set; }

	public string ICA_DADOS_ENVIADOS { get; set; }

	public DateTime? ICA_ULTIMA_EXPORTACAO { get; set; }

	public string CAT_DESCRICAO { get; set; }

	public bool? CAT_INATIVO { get; set; }

	public short? CAT_PAI { get; set; }

	public byte? CAT_ORDEM { get; set; }
}
