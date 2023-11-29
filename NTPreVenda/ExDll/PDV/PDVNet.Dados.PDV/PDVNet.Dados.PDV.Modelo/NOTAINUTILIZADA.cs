using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NOTAINUTILIZADA")]
public class NOTAINUTILIZADA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short NOI_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short NOI_SERIE { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(9)]
	public string NOI_NOTA { get; set; }

	public DateTime? NOI_DATA { get; set; }

	[StringLength(8)]
	public string NOI_MATRICULA { get; set; }

	[StringLength(15)]
	public string NOI_PROTOCOLO { get; set; }

	public byte? NOI_TIPO_NF { get; set; }
}
