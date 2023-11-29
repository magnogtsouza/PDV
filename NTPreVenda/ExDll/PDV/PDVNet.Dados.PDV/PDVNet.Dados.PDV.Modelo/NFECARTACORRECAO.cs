using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NFECARTACORRECAO")]
public class NFECARTACORRECAO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string NFC_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte NFC_SEQ { get; set; }

	[Column(TypeName = "ntext")]
	public string NFC_LOTE { get; set; }

	[Column(TypeName = "ntext")]
	public string NFC_CORRECAO { get; set; }

	public DateTime? NFC_D_CADASTRO { get; set; }

	public DateTime? NFC_D_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string NFC_MATRICULA { get; set; }

	public DateTime? NFC_D_AUTORIZACAO { get; set; }

	[StringLength(15)]
	public string NFC_PROTOCOLO { get; set; }

	public byte? NFC_STATUS { get; set; }

	public byte? NFC_AMBIENTE { get; set; }
}
