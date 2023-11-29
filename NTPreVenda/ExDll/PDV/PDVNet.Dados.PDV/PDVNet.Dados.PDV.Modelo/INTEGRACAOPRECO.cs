using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOPRECO : ICloneable
{
	[Key]
	[Column(Order = 0)]
	public byte INP_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string INP_PDV_CODIGO { get; set; }

	[StringLength(36)]
	public string INP_PLATAFORMA_ID { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string INP_DADOS_ENVIADOS { get; set; }

	public DateTime? INP_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string REF_REFERENCIA { get; set; }

	[NotMapped]
	public string INR_PLATAFORMA_ID { get; set; }

	[NotMapped]
	public byte? RES_AGRUPAMENTO { get; set; }

	[NotMapped]
	public double? PRE_PRECO1 { get; set; }

	[NotMapped]
	public double? PRE_PRECO2 { get; set; }

	[NotMapped]
	public double? PRO_VALOR { get; set; }

	[NotMapped]
	public DateTime? REG_INICIO { get; set; }

	[NotMapped]
	public DateTime? REG_FINAL { get; set; }

	[NotMapped]
	public double? PRECOCUSTO { get; set; }

	[NotMapped]
	public bool? PRINCIPAL { get; set; }

	[NotMapped]
	public byte? TABELAPRECOPDVCODIGO { get; set; }

	[NotMapped]
	public string TABELAPRECOPLATAFORMAID { get; set; }

	public object Clone()
	{
		return new INTEGRACAOPRECO
		{
			INP_CONFIGURACAO = INP_CONFIGURACAO,
			INP_PDV_CODIGO = INP_PDV_CODIGO,
			INP_PLATAFORMA_ID = INP_PLATAFORMA_ID,
			INP_DADOS_ENVIADOS = INP_DADOS_ENVIADOS,
			INP_ULTIMA_EXPORTACAO = INP_ULTIMA_EXPORTACAO,
			REF_REFERENCIA = REF_REFERENCIA,
			INR_PLATAFORMA_ID = INR_PLATAFORMA_ID,
			RES_AGRUPAMENTO = RES_AGRUPAMENTO,
			PRE_PRECO1 = PRE_PRECO1,
			PRE_PRECO2 = PRE_PRECO2,
			PRO_VALOR = PRO_VALOR,
			REG_INICIO = REG_INICIO,
			REG_FINAL = REG_FINAL,
			PRECOCUSTO = PRECOCUSTO,
			PRINCIPAL = PRINCIPAL,
			TABELAPRECOPDVCODIGO = TABELAPRECOPDVCODIGO,
			TABELAPRECOPLATAFORMAID = TABELAPRECOPLATAFORMAID
		};
	}
}
