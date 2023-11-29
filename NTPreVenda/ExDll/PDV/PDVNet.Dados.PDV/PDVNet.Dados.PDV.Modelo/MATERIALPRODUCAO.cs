using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MATERIALPRODUCAO")]
public class MATERIALPRODUCAO
{
	[Key]
	[StringLength(8)]
	public string MTP_CODIGO { get; set; }

	[StringLength(4)]
	public string MTP_SUBGRUPO { get; set; }

	[StringLength(6)]
	public string MTP_FORNECEDOR { get; set; }

	public short? MTP_COLECAO { get; set; }

	[StringLength(200)]
	public string MTP_DESCRICAO { get; set; }

	[StringLength(30)]
	public string MTP_REFERENCIA_FORNECEDOR { get; set; }

	[StringLength(2)]
	public string MTP_UNIDADE_E { get; set; }

	[StringLength(2)]
	public string MTP_UNIDADE_C { get; set; }

	public double? MTP_FATOR { get; set; }

	public bool? MTP_INATIVO { get; set; }

	public DateTime? MTP_CADASTRO { get; set; }

	[StringLength(8)]
	public string MTP_MATRICULA { get; set; }

	public byte? MTP_REDE { get; set; }

	public DateTime? MTP_ATUALIZACAO { get; set; }

	[StringLength(2)]
	public string MTP_GRUPO { get; set; }

	[StringLength(2)]
	public string MTP_FASE { get; set; }

	[StringLength(4)]
	public string MTP_SETOR { get; set; }

	[StringLength(2)]
	public string MTP_MOEDA { get; set; }

	[StringLength(30)]
	public string MTP_REFERENCIA { get; set; }

	public double? MTP_CUSTO { get; set; }

	public double? MTP_VENDA { get; set; }

	[StringLength(255)]
	public string MTP_OBS { get; set; }

	public int? MTP_NCM { get; set; }
}
