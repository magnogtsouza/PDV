using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DFEDOWNLOADXML")]
public class DFEDOWNLOADXML
{
	[Key]
	[Column(Order = 0)]
	[StringLength(50)]
	public string DDX_CHAVE { get; set; }

	public byte DDX_TIPO_DF { get; set; }

	public string DDX_XML { get; set; }

	[StringLength(9)]
	public string DDX_NOTA { get; set; }

	[StringLength(18)]
	public string DDX_CNPJ { get; set; }

	[StringLength(60)]
	public string DDX_NOME { get; set; }

	public double? DDX_VALOR { get; set; }

	public DateTime? DDX_EMISSAO { get; set; }

	[StringLength(6)]
	public string DDX_FORNECEDOR { get; set; }

	public short DDX_FILIAL_DOWNLOAD { get; set; }

	[StringLength(18)]
	public string DDX_CNPJ_DOWNLOAD { get; set; }

	public byte? DDX_STATUS { get; set; }

	public DateTime? DDX_ATUALIZACAO { get; set; }

	public byte? DDX_ORIGEM { get; set; }

	public DateTime? DDX_CADASTRO { get; set; }

	public bool? DDX_TEM_DUPLICATA { get; set; }

	public double? DDX_QUANTIDADE_PECAS { get; set; }
}
