using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOENTIDADE
{
	[Key]
	[Column(Order = 0)]
	public byte IEN_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte IEN_ENTIDADE { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(16)]
	public string IEN_PDV_CODIGO { get; set; }

	[StringLength(36)]
	public string IEN_PLATAFORMA_ID { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string IEN_DADOS_ENVIADOS { get; set; }

	public DateTime? IEN_ULTIMA_EXPORTACAO { get; set; }
}
