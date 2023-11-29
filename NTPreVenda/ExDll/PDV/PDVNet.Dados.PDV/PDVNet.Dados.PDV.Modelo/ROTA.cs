using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ROTA")]
public class ROTA
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short ROT_CODIGO { get; set; }

	[StringLength(100)]
	public string ROT_DESCRICAO { get; set; }

	public bool? ROT_INATIVO { get; set; }

	public DateTime? ROT_CADASTRO { get; set; }

	[StringLength(8)]
	public string ROT_MATRICULA { get; set; }

	public DateTime? ROT_ATUALIZACAO { get; set; }
}
