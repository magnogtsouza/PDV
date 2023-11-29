using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class TELAPROCURA
{
	[Key]
	public short TEL_FORMULARIO { get; set; }

	[Key]
	public byte TEL_SEQ { get; set; }

	[Key]
	public byte TEL_ORIGEM { get; set; }

	[StringLength(30)]
	public string TEL_DESCRICAO { get; set; }

	[StringLength(30)]
	public string TEL_CAMPO { get; set; }

	public byte? TEL_TIPO_PROCURA { get; set; }

	public byte? TEL_TAMANHO { get; set; }

	public bool? TEL_PARCIAL { get; set; }

	public bool? TEL_FORMATAR { get; set; }

	public DateTime? TEL_ATUALIZACAO { get; set; }

	public bool? TEL_INATIVO { get; set; }

	public byte TEL_SEQ_TELA { get; set; }

	[NotMapped]
	public object ExtensaoValor { get; set; }

	[NotMapped]
	public DateTime? ExtensaoDataDe { get; set; }

	[NotMapped]
	public DateTime? ExtensaoDataAte { get; set; }
}
