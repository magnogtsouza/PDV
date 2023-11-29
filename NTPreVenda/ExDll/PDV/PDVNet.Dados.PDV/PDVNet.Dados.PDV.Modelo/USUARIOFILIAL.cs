using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("USUARIOFILIAL")]
public class USUARIOFILIAL
{
	[Key]
	[Column(Order = 0)]
	[StringLength(8)]
	public string USF_USUARIO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short USF_FILIAL { get; set; }

	[StringLength(8)]
	public string USF_MATRICULA { get; set; }

	public DateTime? USF_ATUALIZACAO { get; set; }
}
