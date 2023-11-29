using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SINCRONISMOFILIAL")]
public class SINCRONISMOFILIAL
{
	[Key]
	[Column(Order = 0)]
	public short SIF_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte SIF_CAIXA { get; set; }

	public short SIF_TEMPO_SINCRONISMO { get; set; }

	public DateTime? SIF_ULTIMO_SINCRONISMO { get; set; }

	public bool? SIF_ERRO_SINCRONISMO { get; set; }

	public DateTime? SIF_DATA_BUSCA { get; set; }

	public DateTime? SIF_ATUALIZACAO { get; set; }
}
