using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONTACORRENTE")]
public class CONTACORRENTE
{
	[Key]
	public short CON_CODIGO { get; set; }

	public short? CON_BANCO { get; set; }

	[StringLength(5)]
	public string CON_AGENCIA { get; set; }

	[StringLength(15)]
	public string CON_CONTA { get; set; }

	[StringLength(20)]
	public string CON_GERENTE { get; set; }

	public DateTime? CON_CADASTRO { get; set; }

	public double? CON_SALDO { get; set; }

	public DateTime? CON_ATUALIZACAO { get; set; }

	[StringLength(6)]
	public string CON_ULTIMO_CHEQUE { get; set; }

	[StringLength(30)]
	public string CON_NOME { get; set; }

	public byte? CON_OCULTA { get; set; }

	[StringLength(2)]
	public string CON_GRUPO { get; set; }

	public double? CON_LIMITE { get; set; }

	public bool? CON_OCULTA2 { get; set; }

	public bool? CON_INATIVA { get; set; }

	public bool? CON_GERA_BOLETO { get; set; }

	[StringLength(255)]
	public string CON_MENSAGEM { get; set; }

	[StringLength(255)]
	public string CON_INSTRUCAO1 { get; set; }

	[StringLength(255)]
	public string CON_INSTRUCAO2 { get; set; }

	public double? CON_MORA { get; set; }

	[StringLength(20)]
	public string CON_CODIGO_TRANSMISSAO { get; set; }

	[StringLength(2)]
	public string CON_COMPLEMENTO { get; set; }

	[StringLength(12)]
	public string CON_ULTIMO_NOSSO_NUMERO { get; set; }

	public string ExtensaoUsuarioNome { get; set; }
}
