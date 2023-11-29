using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("GRADEPERCENTUAL")]
public class GRADEPERCENTUAL
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short GRA_CODIGO { get; set; }

	[StringLength(50)]
	public string GRA_DESCRICAO { get; set; }

	public DateTime? GRA_CADASTRO { get; set; }

	public DateTime? GRA_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string GRA_MATRICULA { get; set; }

	public bool? GRA_INATIVA { get; set; }
}
