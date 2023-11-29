using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REJEICOES")]
public class REJEICOES
{
	[Key]
	[Column(Order = 0)]
	public short REJ_CODIGO { get; set; }

	public short? REJ_CODIGO_REJEICAO { get; set; }

	public byte? REJ_TIPO { get; set; }

	public string REJ_TEXTO { get; set; }

	public string REJ_TEXTO_PDVNET { get; set; }

	public bool? REJ_TRAVAR { get; set; }

	public DateTime? REJ_CADASTRO { get; set; }

	public DateTime? REJ_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string REJ_MATRICULA { get; set; }

	public bool? REJ_INATIVO { get; set; }

	public bool? REJ_NAO_NOTIFICAR { get; set; }
}
