using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALCONFIGURACAOEMAIL")]
public class FILIALCONFIGURACAOEMAIL
{
	[Key]
	[Column(Order = 0)]
	public short FCE_FILIAL { get; set; }

	[StringLength(50)]
	public string FCE_EMAIL { get; set; }

	[StringLength(50)]
	public string FCE_REMETENTE { get; set; }

	[StringLength(50)]
	public string FCE_SMTP { get; set; }

	[StringLength(50)]
	public string FCE_USUARIO { get; set; }

	public string FCE_SENHA { get; set; }

	public bool? FCE_AUTENTICACAO_USUARIO { get; set; }

	public bool? FCE_SMTP_SSL { get; set; }

	public bool? FCE_POP_SSL { get; set; }

	public bool? FCE_COPIA_SERVIDOR { get; set; }

	public short? FCE_PORTA_SMTP { get; set; }

	public DateTime? FCE_CADASTRO { get; set; }

	public DateTime? FCE_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string FCE_MATRICULA { get; set; }

	public bool? FCE_INATIVO { get; set; }

	//[NotMapped]
	//public string SenhaDescriptografada => Criptografia.Decryptar(FCE_SENHA);
}
