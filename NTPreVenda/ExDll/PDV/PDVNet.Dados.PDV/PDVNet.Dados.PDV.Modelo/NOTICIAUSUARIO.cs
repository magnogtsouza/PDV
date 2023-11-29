using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NOTICIAUSUARIO")]
public class NOTICIAUSUARIO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short NOU_NOTICIA { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(8)]
	public string NOU_USUARIO { get; set; }

	public DateTime? NOU_D_CADASTRO { get; set; }

	public DateTime? NOU_D_ATUALIZACAO { get; set; }
}
