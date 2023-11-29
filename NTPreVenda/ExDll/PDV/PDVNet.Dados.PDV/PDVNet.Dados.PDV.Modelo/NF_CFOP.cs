using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NF_CFOP")]
public class NF_CFOP
{
	[Key]
	public short NFC_CODIGOFISCAL { get; set; }

	[StringLength(500)]
	public string NFC_DESCRICAO { get; set; }

	public byte? NFC_OPERACAO { get; set; }

	public byte? NFC_REGIAO { get; set; }

	[StringLength(500)]
	public string NFC_APLICACAO { get; set; }

	public DateTime? NFC_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string NFC_MATRICULA { get; set; }

	public bool? NFC_INATIVO { get; set; }
}
