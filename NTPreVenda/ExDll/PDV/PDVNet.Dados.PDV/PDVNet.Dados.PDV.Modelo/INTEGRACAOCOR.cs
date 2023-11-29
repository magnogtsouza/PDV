using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOCOR
{
	[Key]
	[Column(Order = 0)]
	public byte INC_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public short INC_PDV_CODIGO { get; set; }

	[StringLength(36)]
	public string INC_PLATAFORMA_ID { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string INC_DADOS_ENVIADOS { get; set; }

	public DateTime? INC_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string COR_DESCRICAO { get; set; }

	[NotMapped]
	public bool? COR_INATIVO2 { get; set; }

	[NotMapped]
	public string COR_RGB { get; set; }

	[NotMapped]
	public string COR_CODIGO_EXTERNO { get; set; }
}
