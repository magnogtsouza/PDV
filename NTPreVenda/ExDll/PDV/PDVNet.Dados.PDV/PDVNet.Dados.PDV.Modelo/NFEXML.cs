using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class NFEXML
{
	[Key]
	[Column(Order = 0)]
	[StringLength(50)]
	public string NFX_CHAVE { get; set; }

	[StringLength(20)]
	public string NFX_DOC { get; set; }

	public byte? NFX_TIPO_NF { get; set; }

	public string NFX_XML { get; set; }

	public byte? NFX_TIPO { get; set; }

	[StringLength(9)]
	public string NFX_NOTA { get; set; }

	[StringLength(18)]
	public string NFX_CNPJ { get; set; }

	public double? NFX_VALOR { get; set; }

	public DateTime? NFX_EMISSAO { get; set; }

	public DateTime? NFX_ATUALIZACAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte? NFX_STATUS { get; set; }

	public short? NFX_CODIGO_LOJA_DESTINATARIO { get; set; }

	[StringLength(6)]
	public string NFX_FORNECEDOR { get; set; }
}
