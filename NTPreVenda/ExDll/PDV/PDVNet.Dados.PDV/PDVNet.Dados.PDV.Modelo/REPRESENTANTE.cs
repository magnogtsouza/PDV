using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REPRESENTANTE")]
public class REPRESENTANTE
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short REP_CODIGO { get; set; }

	[StringLength(50)]
	public string REP_NOME { get; set; }

	[StringLength(18)]
	public string REP_CGC { get; set; }

	[StringLength(30)]
	public string REP_ENDERECO { get; set; }

	[StringLength(30)]
	public string REP_BAIRRO { get; set; }

	[StringLength(30)]
	public string REP_CIDADE { get; set; }

	[StringLength(10)]
	public string REP_CEP { get; set; }

	[StringLength(2)]
	public string REP_ESTADO { get; set; }

	[StringLength(6)]
	public string REP_PREFIXO { get; set; }

	[StringLength(15)]
	public string REP_TELEFONE { get; set; }

	[StringLength(15)]
	public string REP_FAX { get; set; }

	[StringLength(15)]
	public string REP_CELULAR { get; set; }

	[StringLength(50)]
	public string REP_EMAIL { get; set; }

	[StringLength(50)]
	public string REP_EMAIL2 { get; set; }

	[StringLength(100)]
	public string REP_OBS { get; set; }

	public DateTime? REP_CADASTRO { get; set; }

	public DateTime? REP_ATUALIZACAO { get; set; }

	public DateTime? REP_NASCIMENTO { get; set; }

	public double? REP_COMISSAO { get; set; }

	public bool? REP_INATIVO { get; set; }

	[StringLength(100)]
	public string REP_DESCRICAO { get; set; }

	[StringLength(16)]
	public string REP_CHAVE { get; set; }

	public byte? REP_TIPO_CADASTRO { get; set; }

	public byte? REP_TIPO { get; set; }

	[StringLength(8)]
	public string REP_MATRICULA { get; set; }
}
