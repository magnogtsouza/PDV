using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MOTIVO")]
public class MOTIVO
{
	[Key]
	[Column(Order = 0)]
	public short MOT_CODIGO { get; set; }

	[StringLength(50)]
	public string MOT_DESCRICAO { get; set; }

	public byte? MOT_TIPO { get; set; }

	public bool? MOT_INATIVO { get; set; }

	public DateTime? MOT_ATUALIZACAO { get; set; }

	public short? MOT_FILIAL_TRANSFERENCIA { get; set; }
}
