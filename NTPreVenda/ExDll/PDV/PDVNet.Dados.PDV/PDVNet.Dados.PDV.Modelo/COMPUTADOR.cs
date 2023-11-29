using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("COMPUTADOR")]
public class COMPUTADOR
{
	[Column(Order = 0)]
	public short COM_LOJA_SUPORTE { get; set; }

	[Column(Order = 1)]
	[StringLength(15)]
	public string COM_SERIAL { get; set; }

	[Column(Order = 2)]
	[StringLength(30)]
	public string COM_NOME { get; set; }

	public DateTime? COM_ULTIMO_ACESSO { get; set; }

	public byte? COM_PDVSYNC_RECEBER { get; set; }

	public short? COM_NFCE_SERIE { get; set; }

	[StringLength(30)]
	public string COM_FRAMEWORK { get; set; }

	public byte? COM_TIPO_SISTEMA { get; set; }

	public byte? COM_IMPRESSORA { get; set; }

	public byte? COM_SEDE { get; set; }

	[StringLength(100)]
	public string COM_SO { get; set; }

	public byte? COM_CAIXA { get; set; }

	public byte? COM_TELAS_NOVAS { get; set; }

	public bool? COM_CFE_SERVIDOR { get; set; }

	public byte? COM_NUMERO_CAIXA { get; set; }

	public bool? COM_NAO_ABRIR_PDVSYNC { get; set; }

	public byte? COM_FORMA_VENDA { get; set; }

	public short? COM_FILIAL { get; set; }

	[StringLength(8)]
	public string COM_MATRICULA { get; set; }

	public DateTime? COM_ATUALIZACAO { get; set; }

	[StringLength(50)]
	public string COM_IMPRESSORA_DESCRICAO { get; set; }

	[StringLength(10)]
	public string COM_RESOLUCAO { get; set; }

	public int? COM_PONTO_CAPTURA { get; set; }

	[StringLength(50)]
	public string COM_IP_TEF { get; set; }

	public bool? COM_PDVINTEGRADOR { get; set; }

	public bool? COM_WMS { get; set; }

	public int? COM_CODIGO { get; set; }

	public Guid? COM_ID { get; set; }

	public DateTime? COM_ULTIMA_EXECUCAO_PDVUP_UTC { get; set; }

	public bool? COM_NAO_ABRIR_MONITOR { get; set; }

	[Key]
	public Guid COM_GUID { get; set; }

	public bool? COM_ACCESS_STAGE { get; set; }
}
