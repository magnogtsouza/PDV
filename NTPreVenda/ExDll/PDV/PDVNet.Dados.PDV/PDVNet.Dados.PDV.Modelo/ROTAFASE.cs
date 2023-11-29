using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ROTAFASE")]
public class ROTAFASE
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short ROF_ROTA { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(2)]
	public string ROF_FASE { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte ROF_SEQ { get; set; }

	public DateTime? ROF_CADASTRO { get; set; }

	[StringLength(8)]
	public string ROF_MATRICULA { get; set; }

	public DateTime? ROF_ATUALIZACAO { get; set; }

	public int ROT_ROTA { get; set; }

	[Required]
	[StringLength(2)]
	public string ROT_FASE { get; set; }

	public byte ROT_SEQ { get; set; }

	public DateTime? ROT_CADASTRO { get; set; }

	[StringLength(8)]
	public string ROT_MATRICULA { get; set; }

	public DateTime? ROT_ATUALIZACAO { get; set; }
}
