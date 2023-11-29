using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONTAGEM")]
public class CONTAGEM
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CON_CODIGO { get; set; }

	[StringLength(100)]
	public string CON_DESCRICAO { get; set; }

	public DateTime? CON_CADASTRO { get; set; }

	public DateTime? CON_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CON_MATRICULA { get; set; }

	public byte? CON_INATIVA { get; set; }

	[StringLength(15)]
	public string CON_SERIAL { get; set; }

	public byte? CON_UTILIZADA { get; set; }
}
