using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class NFEWS
{
	[Key]
	[Column(Order = 0)]
	public byte NWS_COD_IBGE { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte NWS_AMBIENTE { get; set; }

	[StringLength(100)]
	public string NWS_STATUS_SERVICO { get; set; }

	[StringLength(100)]
	public string NWS_ENVIO { get; set; }

	[StringLength(100)]
	public string NWS_RETORNO_ENVIO { get; set; }

	[StringLength(100)]
	public string NWS_CONSULTA { get; set; }

	[StringLength(100)]
	public string NWS_CANCELAMENTO { get; set; }

	[StringLength(100)]
	public string NWS_INUTILIZACAO { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(4)]
	public string NWS_VERSAO { get; set; }

	[StringLength(100)]
	public string NWS_EVENTO { get; set; }

	public DateTime? NWS_D_ALTERACAO { get; set; }

	[StringLength(100)]
	public string NWS_AUTORIZACAO { get; set; }

	[StringLength(100)]
	public string NWS_RETORNO_AUTORIZACAO { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte NWS_TIPO_NF { get; set; }

	[StringLength(100)]
	public string NWS_ENDERECO_CONSULTA_QRCODE { get; set; }

	[StringLength(100)]
	public string NWS_ENDERECO_CONSULTA { get; set; }

	public double? NWS_VALOR_LIMITE_ENDERECO_NFCE { get; set; }

	public bool? NWS_HABILITA_RESPONSAVEL_TECNICO { get; set; }
}
