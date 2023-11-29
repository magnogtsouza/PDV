using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOESTOQUE
{
	[Key]
	[Column(Order = 0)]
	public byte INE_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(14)]
	public string INE_PDV_CODIGO { get; set; }

	[StringLength(36)]
	public string INE_PLATAFORMA_ID { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string INE_DADOS_ENVIADOS { get; set; }

	public DateTime? INE_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public double? SAL_SALDO { get; set; }

	[NotMapped]
	public double? ESTOQUE { get; set; }

	[NotMapped]
	public double? ESTOQUE_RESERVADO { get; set; }

	[NotMapped]
	public string ICB_PLATAFORMA_ID { get; set; }

	[NotMapped]
	public string REF_REFERENCIA { get; set; }

	[NotMapped]
	public string INR_PLATAFORMA_ID { get; set; }

	[NotMapped]
	public byte? RES_EXIBIR { get; set; }

	[NotMapped]
	public byte? RES_AGRUPAMENTO { get; set; }

	[NotMapped]
	public short? SAL_FILIAL { get; set; }

	[NotMapped]
	public string IFI_ID_PLATAFORMA { get; set; }

	[NotMapped]
	public double PRECOCUSTO { get; set; }
}
