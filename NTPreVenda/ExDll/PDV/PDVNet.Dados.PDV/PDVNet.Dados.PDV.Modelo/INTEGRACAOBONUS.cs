using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOBONUS
{
	[Key]
	public byte? INB_CONFIGURACAO { get; set; }

	[Key]
	public string INB_PDV_CODIGO { get; set; }

	[Key]
	public byte? INB_PDV_SEQ { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string INB_DADOS_ENVIADOS { get; set; }

	public DateTime? INB_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	public double? BEX_VALOR { get; set; }

	[NotMapped]
	public DateTime? BON_VALIDADE { get; set; }

	[NotMapped]
	public byte? BEX_SEQ { get; set; }

	[NotMapped]
	public short? BEX_STATUS { get; set; }

	[NotMapped]
	public DateTime? BEX_DATA { get; set; }

	[NotMapped]
	public DateTime? BON_D_USO { get; set; }

	[NotMapped]
	public bool? BON_EXCLUIDO { get; set; }

	[NotMapped]
	public string INC_PLATAFORMA_ID { get; set; }

	[NotMapped]
	[StringLength(50)]
	public string CLI_NOME { get; set; }

	[NotMapped]
	[StringLength(18)]
	public string CLI_CGC { get; set; }
}
