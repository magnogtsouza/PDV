using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NOTAFISCALSERVICO")]
public class NOTAFISCALSERVICO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public string NOS_DOC { get; set; }

	public int NOS_RPS { get; set; }

	public short? NOS_FILIAL { get; set; }

	public short? NOS_SERIE { get; set; }

	public DateTime? NOS_EMISSAO { get; set; }

	public byte? NOS_NATUREZA_OPERACAO { get; set; }

	public double? NOS_VALOR { get; set; }

	[StringLength(20)]
	public string NOS_NFSE_NUMERO { get; set; }

	public DateTime? NOS_NFSE_EMISSAO { get; set; }

	public int? NOS_NFSE_LOTE { get; set; }

	public byte? NOS_NFSE_STATUS { get; set; }

	[StringLength(9)]
	public string NOS_NFSE_CODIGO_VERIFICACAO { get; set; }

	[StringLength(255)]
	public string NOS_OBS { get; set; }

	public short? NOS_CONDICAO { get; set; }

	[StringLength(16)]
	public string NOS_CODIGON { get; set; }

	public byte? NOS_TABELA { get; set; }

	public DateTime? NOS_ATUALIZACAO { get; set; }

	[StringLength(16)]
	public string NOS_MATRICULA { get; set; }

	public double? NOS_COFINS { get; set; }

	public double? NOS_PIS { get; set; }

	public double? NOS_CSLL { get; set; }

	public double? NOS_IRPJ { get; set; }

	public short? NOS_STATUS { get; set; }

	public bool? NOS_ISS_RETIDO { get; set; }

	[StringLength(20)]
	public string NOS_DOC_SUBSTITUIDO { get; set; }

	public short? NOS_LOTE { get; set; }

	[NotMapped]
	public virtual ICollection<NOTAFISCALSERVICOITEM> Itens { get; set; }

	[NotMapped]
	public virtual ICollection<DUPLICATAS> Duplicatas { get; set; }

	[NotMapped]
	public string UsuarioNome { get; set; }

	public NOTAFISCALSERVICO()
	{
		Itens = new List<NOTAFISCALSERVICOITEM>();
	}
}
