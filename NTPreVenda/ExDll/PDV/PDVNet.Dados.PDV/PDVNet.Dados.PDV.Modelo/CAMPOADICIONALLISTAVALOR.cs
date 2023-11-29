using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CAMPOADICIONALLISTAVALOR")]
public class CAMPOADICIONALLISTAVALOR
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CLV_CAMPO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int CLV_CODIGO { get; set; }

	[StringLength(255)]
	public string CLV_DESCRICAO { get; set; }

	public byte? CLV_INATIVO { get; set; }

	[StringLength(8)]
	public string CLV_MATRICULA { get; set; }

	public DateTime? CLV_CADASTRO { get; set; }

	public DateTime? CLV_ATUALIZACAO { get; set; }
}
