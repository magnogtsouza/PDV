using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class INTEGRACAOCLIENTES
{
	[Key]
	public byte? INC_CONFIGURACAO { get; set; }

	[Key]
	public string INC_PDV_CODIGON { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string INC_DADOS_ENVIADOS { get; set; }

	public string INC_PLATAFORMA_ID { get; set; }

	public DateTime? INC_ULTIMA_EXPORTACAO { get; set; }

	[NotMapped]
	[StringLength(15)]
	public string CLI_CELULAR { get; set; }

	[NotMapped]
	[StringLength(18)]
	public string CLI_CGC { get; set; }

	[NotMapped]
	[StringLength(15)]
	public string CLI_COMERCIAL { get; set; }

	[NotMapped]
	public DateTime? CLI_NASCIMENTO { get; set; }

	[NotMapped]
	[StringLength(50)]
	public string CLI_EMAIL { get; set; }

	[NotMapped]
	[StringLength(70)]
	public string CLI_NOME { get; set; }

	[NotMapped]
	[StringLength(6)]
	public string CLI_PREFIXO { get; set; }

	[NotMapped]
	public byte? CLI_SEXO { get; set; }

	[NotMapped]
	[StringLength(15)]
	public string CLI_TELEFONE { get; set; }

	[NotMapped]
	[StringLength(15)]
	public string CLI_IDENTIDADE { get; set; }

	[NotMapped]
	public bool? CLI_INATIVO { get; set; }

	[NotMapped]
	public byte? CLI_ATACADO { get; set; }
}
