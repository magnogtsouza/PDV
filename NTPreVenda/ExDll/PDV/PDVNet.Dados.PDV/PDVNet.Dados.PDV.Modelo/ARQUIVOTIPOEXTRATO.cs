using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ARQUIVOTIPOEXTRATO")]
public class ARQUIVOTIPOEXTRATO
{
	[Key]
	[Column(Order = 0)]
	public short ATE_CODIGO { get; set; }

	[StringLength(30)]
	public string ATE_DESCRICAO { get; set; }

	public short? ATE_ARQUIVOENTIDADE { get; set; }

	[StringLength(5)]
	public string ATE_TIPO { get; set; }

	public bool? ATE_INATIVO { get; set; }

	public DateTime? ATE_ATUALIZACAO { get; set; }

	[NotMapped]
	public List<ARQUIVOTIPOREGISTRO> TiposRegistros { get; set; }
}
