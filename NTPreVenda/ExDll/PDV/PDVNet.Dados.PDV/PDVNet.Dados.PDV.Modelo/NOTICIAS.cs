using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class NOTICIAS
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short NOT_CODIGO { get; set; }

	public DateTime? NOT_VERSAO { get; set; }

	[StringLength(50)]
	public string NOT_TITULO { get; set; }

	[Column(TypeName = "ntext")]
	public string NOT_NOTICIA { get; set; }

	public DateTime? NOT_DATA { get; set; }

	public byte? NOT_LIDA { get; set; }

	public byte? NOT_TIPO { get; set; }

	public short? NOT_SISTEMA { get; set; }

	public short? NOT_AUTOR { get; set; }

	public DateTime? NOT_ATUALIZACAO { get; set; }

	public bool? NOT_INATIVO { get; set; }

	public byte? NOT_APROVADO { get; set; }

	public short? NOT_CATEGORIA { get; set; }

	public short? NOT_COD_FORM { get; set; }
}
