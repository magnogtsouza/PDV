using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEG_FOURMIDDLEWARE_PRODUCT
{
	[Key]
	[Column(Order = 0)]
	public byte PRO_CONFIGURACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte PRO_PDV_REDE { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(12)]
	public string PRO_PDV_REFERENCIA { get; set; }

	[StringLength(30)]
	public string PRO_PRODUCT_ID_ON_SELLER { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string PRO_DADOS_ENVIADOS { get; set; }

	public DateTime? PRO_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public string ExtensaoMarcaDescricao { get; set; }

	[NotMapped]
	public int? ExtensaoMarcaCodigo { get; set; }
}
