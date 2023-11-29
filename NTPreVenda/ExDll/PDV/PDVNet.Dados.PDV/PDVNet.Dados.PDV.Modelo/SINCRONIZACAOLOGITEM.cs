using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SINCRONIZACAOLOGITEM")]
public class SINCRONIZACAOLOGITEM
{
	[Key]
	[Column(Order = 0)]
	public int SLI_SEQ { get; set; }

	[Key]
	[Column(Order = 1)]
	public short SLI_TABELA { get; set; }

	[Key]
	[Column(Order = 2)]
	public short SLI_PACOTE { get; set; }

	public int? SLI_ENCONTRADOS { get; set; }

	public int? SLI_NOVOS { get; set; }

	public int? SLI_ATUALIZADOS { get; set; }

	public DateTime? SLI_ULTIMO_REGISTRO { get; set; }

	public bool? SLI_ERRO { get; set; }

	[NotMapped]
	public string Descricao { get; set; }

	[NotMapped]
	public string Negocio { get; set; }
}
