using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class CHEQUES
{
	[Key]
	public int CHE_CODIGO { get; set; }

	public short CHE_BANCO { get; set; }

	public short? CHE_FILIAL { get; set; }

	[StringLength(50)]
	public string CHE_HISTORICO { get; set; }

	public DateTime? CHE_EMISSAO { get; set; }

	public DateTime? CHE_CADASTRO { get; set; }

	public double? CHE_VALOR { get; set; }

	[StringLength(1)]
	public string CHE_STATUS { get; set; }

	[StringLength(6)]
	public string CHE_NUMERO { get; set; }

	public DateTime? CHE_VENCIMENTO { get; set; }

	public DateTime? CHE_COMPENSADO { get; set; }

	public byte? CHE_TIPO { get; set; }

	public DateTime? CHE_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CHE_MATRICULA { get; set; }
}
