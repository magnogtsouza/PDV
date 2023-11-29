using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ARQUIVOTIPOREGISTRO")]
public class ARQUIVOTIPOREGISTRO
{
	[Key]
	[Column(Order = 0)]
	public short ATR_CODIGO { get; set; }

	[StringLength(30)]
	public string ATR_DESCRICAO { get; set; }

	public short? ATR_TIPO_EXTRATO { get; set; }

	[StringLength(3)]
	public string ATR_TIPO_REGISTRO { get; set; }

	public bool? ATR_INATIVO { get; set; }

	public DateTime? ATR_ATUALIZACAO { get; set; }

	[NotMapped]
	public List<ARQUIVOCNABCAMPO> Campos { get; set; }
}
