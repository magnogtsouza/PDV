using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOPEDIDO
{
	[Key]
	[Column(Order = 0)]
	public byte IPE_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string IPE_PDV_DOC { get; set; }

	[StringLength(40)]
	public string IPE_PLATAFORMA_ID { get; set; }

	[StringLength(40)]
	public string IPE_PLATAFORMA_ID_SECUNDARIO { get; set; }

	[StringLength(20)]
	public string IPE_PLATAFORMA_ORIGEM { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string IPE_DADOS_RECEBIDOS { get; set; }

	[StringLength(30)]
	public string IPE_MARKETPLACE { get; set; }

	public DateTime? IPE_ULTIMA_EXPORTACAO { get; set; }
}
