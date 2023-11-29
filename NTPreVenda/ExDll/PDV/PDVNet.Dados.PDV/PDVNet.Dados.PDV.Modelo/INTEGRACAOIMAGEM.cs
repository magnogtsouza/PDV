using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOIMAGEM
{
	[Key]
	[Column(Order = 0)]
	public byte IIM_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short IIM_PDV_TIPO { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(16)]
	public string IIM_PDV_CODIGO { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte IIM_PDV_REDE { get; set; }

	[Key]
	[Column(Order = 4)]
	public byte IIM_PDV_SEQ { get; set; }

	[StringLength(20)]
	public string IIM_PLATAFORMA_ID { get; set; }

	public DateTime? IIM_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public byte[] IMA_IMAGEM { get; set; }

	[NotMapped]
	public bool? IMA_INATIVO { get; set; }

	[NotMapped]
	public string INR_PLATAFORMA_ID { get; set; }

	[NotMapped]
	public string INR_PDV_REFERENCIA { get; set; }

	[NotMapped]
	public string ICB_PLATAFORMA_ID { get; set; }

	[NotMapped]
	public string ICB_PDV_CODIGO { get; set; }

	[NotMapped]
	public short? INR_PDV_COR { get; set; }

	[NotMapped]
	public string COR_DESCRICAO { get; set; }

	[NotMapped]
	public short? INR_PDV_TAMANHO { get; set; }

	[NotMapped]
	public string TAM_TAMANHO { get; set; }

	[NotMapped]
	public byte? RES_AGRUPAMENTO { get; set; }

	[NotMapped]
	public byte? GRA_CODIGO { get; set; }

	[NotMapped]
	public short? MAT_COR { get; set; }

	[NotMapped]
	public short? MAT_TAMANHO { get; set; }
}
