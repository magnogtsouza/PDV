using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOCODIGOBARRAS
{
	[Key]
	[Column(Order = 0)]
	public byte ICB_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string ICB_PDV_CODIGO { get; set; }

	[StringLength(36)]
	public string ICB_PLATAFORMA_ID { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string ICB_DADOS_ENVIADOS { get; set; }

	public DateTime? ICB_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string REF_REFERENCIA { get; set; }

	[NotMapped]
	public string UNI_DESCRICAO { get; set; }

	[NotMapped]
	public string INR_PLATAFORMA_ID { get; set; }

	[NotMapped]
	public string INC_PLATAFORMA_ID { get; set; }

	[NotMapped]
	public string INT_PLATAFORMA_ID { get; set; }

	[NotMapped]
	public string MAT_EAN { get; set; }

	[NotMapped]
	public string NCM_NCM { get; set; }

	[NotMapped]
	public bool? MAT_INATIVO { get; set; }

	[NotMapped]
	public short? COR_CODIGO { get; set; }

	[NotMapped]
	public string COR_DESCRICAO { get; set; }

	[NotMapped]
	public string COR_RGB { get; set; }

	[NotMapped]
	public short? TAM_CODIGO { get; set; }

	[NotMapped]
	public string TAM_TAMANHO { get; set; }

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
	public double? SAL_SALDO { get; set; }

	[NotMapped]
	public double? ESTOQUE { get; set; }

	[NotMapped]
	public double? ESTOQUE_RESERVADO { get; set; }

	[NotMapped]
	public string REF_DESCRICAO { get; set; }

	[NotMapped]
	public string RES_NOME { get; set; }

	[NotMapped]
	public string RES_DESCRICAO { get; set; }

	[NotMapped]
	public string RES_DESCRICAO_CURTA { get; set; }

	[NotMapped]
	public string RES_PALAVRAS { get; set; }

	[NotMapped]
	public double? RES_PESO { get; set; }

	[NotMapped]
	public double? RES_ALTURA { get; set; }

	[NotMapped]
	public double? RES_LARGURA { get; set; }

	[NotMapped]
	public double? RES_PROFUNDIDADE { get; set; }

	[NotMapped]
	public byte? RES_EXIBIR { get; set; }

	[NotMapped]
	public byte? RES_AGRUPAMENTO { get; set; }

	[NotMapped]
	public double? REF_PESO_BRUTO { get; set; }

	[NotMapped]
	public double? REF_ALTURA { get; set; }

	[NotMapped]
	public double? REF_LARGURA { get; set; }

	[NotMapped]
	public double? REF_PROFUNDIDADE { get; set; }

	[NotMapped]
	public bool? REF_INATIVO2 { get; set; }

	[NotMapped]
	public byte? GRA_CODIGO { get; set; }

	[NotMapped]
	public string GRA_DESCRICAO { get; set; }

	[NotMapped]
	public string ING_PLATAFORMA_ID { get; set; }

	[NotMapped]
	public bool? RES_NAO_CONTROLA { get; set; }
}
