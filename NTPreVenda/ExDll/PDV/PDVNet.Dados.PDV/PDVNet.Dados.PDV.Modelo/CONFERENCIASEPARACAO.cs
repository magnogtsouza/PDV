using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONFERENCIASEPARACAO")]
public class CONFERENCIASEPARACAO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short COS_CODIGO { get; set; }

	public DateTime? COS_CADASTRO { get; set; }

	public DateTime? COS_ATUALIZACAO { get; set; }

	public int? COS_SEPARACAO { get; set; }

	[StringLength(8)]
	public string COS_MATRICULA { get; set; }

	public bool? COS_INATIVA { get; set; }

	[StringLength(15)]
	public string COS_SERIAL { get; set; }
}
