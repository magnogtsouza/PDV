using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CONTADORES
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short CON_CODIGO { get; set; }

	[StringLength(100)]
	public string CON_NOME { get; set; }

	[StringLength(11)]
	public string CON_CPF { get; set; }

	[StringLength(15)]
	public string CON_CRC { get; set; }

	[StringLength(14)]
	public string CON_CNPJ { get; set; }

	[StringLength(4)]
	public string CON_PREFIXO { get; set; }

	[StringLength(15)]
	public string CON_TELEFONE { get; set; }

	[StringLength(15)]
	public string CON_FAX { get; set; }

	[StringLength(50)]
	public string CON_EMAIL { get; set; }

	public bool? CON_INATIVO { get; set; }

	public DateTime? CON_CADASTRO { get; set; }

	[StringLength(8)]
	public string CON_MATRICULA { get; set; }

	public DateTime? CON_ATUALIZACAO { get; set; }

	[StringLength(16)]
	public string CON_CHAVE { get; set; }

	public byte? CON_TIPO_CADASTRO { get; set; }
}
