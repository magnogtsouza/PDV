using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOTAMANHO
{
	[Key]
	[Column(Order = 0)]
	public byte INT_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short INT_PDV_CODIGO { get; set; }

	[StringLength(36)]
	public string INT_PLATAFORMA_ID { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string INT_DADOS_ENVIADOS { get; set; }

	public DateTime? INT_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string TAM_TAMANHO { get; set; }

	[NotMapped]
	public bool? TAM_INATIVO { get; set; }

	[NotMapped]
	public short? TAM_ORDEM { get; set; }

	[NotMapped]
	public byte GRA_CODIGO { get; set; }

	[NotMapped]
	public string ING_PLATAFORMA_ID { get; set; }
}
