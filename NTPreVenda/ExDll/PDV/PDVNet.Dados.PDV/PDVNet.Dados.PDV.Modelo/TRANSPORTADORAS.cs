using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class TRANSPORTADORAS
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short TRA_CODIGO { get; set; }

	[StringLength(40)]
	public string TRA_NOME { get; set; }

	[StringLength(18)]
	public string TRA_CGC { get; set; }

	[StringLength(15)]
	public string TRA_TELEFONE { get; set; }

	[StringLength(18)]
	public string TRA_INSCRICAO { get; set; }

	[StringLength(15)]
	public string TRA_FAX { get; set; }

	[StringLength(6)]
	public string TRA_PREFIXO { get; set; }

	[StringLength(1)]
	public string TRA_TIPO { get; set; }

	[StringLength(20)]
	public string TRA_CONTATO { get; set; }

	[StringLength(40)]
	public string TRA_FANTASIA { get; set; }

	public DateTime? TRA_CADASTRO { get; set; }

	public DateTime? TRA_ATUALIZACAO { get; set; }

	public bool? TRA_INATIVA { get; set; }

	[StringLength(8)]
	public string TRA_MATRICULA { get; set; }

	[StringLength(16)]
	public string TRA_CHAVE { get; set; }

	public byte? TRA_TIPO_CADASTRO { get; set; }

	public byte? TRA_ENDERECO_PADRAO { get; set; }

	public byte? TRA_EXIBE_LOJA { get; set; }

	[StringLength(8)]
	public string TRA_PLACA { get; set; }

	public byte? TRA_PLACA_UF { get; set; }

	[StringLength(50)]
	public string TRA_CODIGO_EXTERNO { get; set; }
}
