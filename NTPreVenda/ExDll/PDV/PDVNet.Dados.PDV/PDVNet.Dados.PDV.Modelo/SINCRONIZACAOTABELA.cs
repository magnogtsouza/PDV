using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SINCRONIZACAOTABELA")]
public class SINCRONIZACAOTABELA
{
	[Key]
	public short STA_CODIGO { get; set; }

	public DateTime? STA_ULTIMA_SINCRONIZACAO { get; set; }

	public DateTime? STA_ULTIMO_REGISTRO { get; set; }
}
