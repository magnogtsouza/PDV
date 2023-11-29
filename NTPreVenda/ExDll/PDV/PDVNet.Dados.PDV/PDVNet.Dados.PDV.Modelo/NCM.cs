using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NCM")]
public class NCM
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short NCM_CODIGO { get; set; }

	[StringLength(60)]
	public string NCM_DESCRICAO { get; set; }

	[StringLength(8)]
	public string NCM_NCM { get; set; }

	public DateTime? NCM_CADASTRO { get; set; }

	public DateTime? NCM_ATUALIZACAO { get; set; }

	public bool? NCM_INATIVO { get; set; }

	[StringLength(8)]
	public string NCM_MATRICULA { get; set; }

	public double? NCM_ALIQUOTA_NACIONAL { get; set; }

	public double? NCM_ALIQUOTA_IMPORTADA { get; set; }
}
