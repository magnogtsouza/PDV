using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILTROCONFIGURACAO")]
public class FILTROCONFIGURACAO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public byte? FIC_CODIGO { get; set; }

	[StringLength(30)]
	public string FIC_DESCRICAO { get; set; }

	[StringLength(30)]
	public string FIC_CAMPO_CODIGO { get; set; }

	[StringLength(30)]
	public string FIC_TABELA { get; set; }

	[StringLength(30)]
	public string FIC_CAMPO_DESCRICAO { get; set; }

	public byte? FIC_TIPO { get; set; }

	public byte? FIC_REDE { get; set; }

	[StringLength(20)]
	public string FIC_INATIVO { get; set; }

	[StringLength(6)]
	public string FIC_LINK { get; set; }

	[StringLength(4)]
	public string FIC_PREFIXO { get; set; }

	[StringLength(6)]
	public string FIC_LINK2 { get; set; }

	public bool? FIC_PRODUTO { get; set; }

	[StringLength(30)]
	public string FIC_CAMPO_NEGOCIO { get; set; }

	public bool? FIC_DIGITAVEL { get; set; }

	public bool? FIC_GRAVAR { get; set; }

	public bool? FIC_LISTA { get; set; }

	public DateTime? FIC_ATUALIZACAO { get; set; }
}
