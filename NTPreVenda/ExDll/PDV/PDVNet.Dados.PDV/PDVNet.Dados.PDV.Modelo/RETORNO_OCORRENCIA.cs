using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class RETORNO_OCORRENCIA
{
	[Key]
	[Column(Order = 0)]
	public short RET_BANCO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(2)]
	public string RET_CODIGO { get; set; }

	[StringLength(255)]
	public string RET_DESCRICAO { get; set; }

	public byte? RET_BAIXAR { get; set; }

	public short RET_CLASSIFICACAO { get; set; }

	public DateTime? RET_ATUALIZACAO { get; set; }

	public byte? RET_INATIVO { get; set; }
}
