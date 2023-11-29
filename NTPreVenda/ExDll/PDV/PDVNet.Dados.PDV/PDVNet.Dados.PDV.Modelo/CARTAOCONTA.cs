using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CARTAOCONTA")]
public class CARTAOCONTA
{
	[Key]
	[Column(Order = 0)]
	public byte CAR_CARTAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int CAR_FILIAL { get; set; }

	public short CAR_BANCO { get; set; }

	public short? CAR_P_ROTATIVO { get; set; }

	public double? CAR_T_ROTATIVO { get; set; }

	public short? CAR_P_PARCELADO { get; set; }

	public double? CAR_T_PARCELADO { get; set; }

	public byte? CAR_TEF { get; set; }

	public DateTime? CAR_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CAR_MATRICULA { get; set; }

	[NotMapped]
	public byte? ExtensaoTipoCartao { get; set; }
}
