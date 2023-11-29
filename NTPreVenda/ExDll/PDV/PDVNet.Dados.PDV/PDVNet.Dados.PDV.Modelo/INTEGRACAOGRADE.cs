using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOGRADE
{
	[Key]
	[Column(Order = 0)]
	public byte ING_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte ING_PDV_CODIGO { get; set; }

	[StringLength(36)]
	public string ING_PLATAFORMA_ID { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string ING_DADOS_ENVIADOS { get; set; }

	public DateTime? ING_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string GRA_DESCRICAO { get; set; }

	[NotMapped]
	public bool? GRA_INATIVO { get; set; }
}
