using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAMBIO")]
public class CAMBIO
{
	[Key]
	[Column(Order = 0)]
	public byte CAM_MOEDA { get; set; }

	[Key]
	[Column(Order = 1)]
	public DateTime CAM_DATA { get; set; }

	public double? CAM_CAMBIO { get; set; }

	public DateTime? CAM_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CAM_MATRICULA { get; set; }

	public bool? CAM_INATIVO { get; set; }
}
