using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SINCRONIZACAOTABELALOG")]
public class SINCRONIZACAOTABELALOG
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int STL_CODIGO { get; set; }

	public short STL_TABELA { get; set; }

	public DateTime? STL_DATA_INICIO { get; set; }

	public DateTime? STL_DATA_FIM { get; set; }

	public int STL_ENCONTRADOS { get; set; }

	public int STL_NOVOS { get; set; }

	public int STL_ATUALIZADOS { get; set; }

	public int STL_RECEBIDOS { get; set; }

	public int STL_PACOTES { get; set; }
}
