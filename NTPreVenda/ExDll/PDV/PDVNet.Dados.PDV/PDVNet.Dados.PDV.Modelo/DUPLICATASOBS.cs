using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class DUPLICATASOBS
{
	[StringLength(8)]
	public string DUO_DUPLICATA { get; set; }

	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short DUO_SERIE { get; set; }

	public short DUO_FILIAL { get; set; }

	public byte DUO_SEQ { get; set; }

	public DateTime? DUO_CADASTRO { get; set; }

	[StringLength(8)]
	public string DUO_MATRICULA { get; set; }

	[Column(TypeName = "ntext")]
	public string DUO_OBSERVACAO { get; set; }

	public bool? DUO_INATIVO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public Guid DUO_GUID { get; set; }
}
