using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TEFNOVA")]
public class TEFNOVA
{
	public byte TEF_TIPO { get; set; }

	[StringLength(12)]
	public string TEF_NSU { get; set; }

	[StringLength(30)]
	public string TEF_FINALIZACAO { get; set; }

	public double? TEF_VALOR { get; set; }

	public DateTime? TEF_DATA { get; set; }

	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int TEF_SEQ { get; set; }

	public short? TEF_REDE { get; set; }

	[Key]
	[Column(Order = 1)]
	[Required]
	[StringLength(20)]
	public string TEF_DOC { get; set; }

	[Column(TypeName = "ntext")]
	public string TEF_VIA_UNICA { get; set; }

	[Column(TypeName = "ntext")]
	public string TEF_VIA_CLIENTE { get; set; }

	[Column(TypeName = "ntext")]
	public string TEF_VIA_ESTABELECIMENTO { get; set; }

	[Column(TypeName = "ntext")]
	public string TEF_VIA_CANCELAMENTO { get; set; }

	[StringLength(6)]
	public string TEF_AUTORIZACAO { get; set; }

	public byte? TEF_PARCELAS { get; set; }

	public byte? TEF_STATUS { get; set; }

	public string TEF_ARQUIVO { get; set; }

	public double? TEF_VALOR_VENDA { get; set; }

	[StringLength(30)]
	public string TEF_REDE_TEF { get; set; }

	[StringLength(50)]
	public string TEF_CARTAO_TEF { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte TEF_OPERACAO { get; set; }
}
