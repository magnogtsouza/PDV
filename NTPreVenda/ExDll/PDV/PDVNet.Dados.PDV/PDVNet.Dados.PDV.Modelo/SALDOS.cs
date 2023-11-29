using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class SALDOS
{
	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string SAL_PRODUTO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short SAL_FILIAL { get; set; }

	public double? SAL_SALDO { get; set; }

	public double? SAL_SALDO_ANTIGO { get; set; }

	public DateTime? SAL_D_BALANCO { get; set; }

	public double? SAL_TRANSITO { get; set; }

	public DateTime? SAL_D_VENDA { get; set; }

	public DateTime? SAL_ULT_COMPRA { get; set; }

	public DateTime? SAL_DISTRIBUICAO { get; set; }

	public DateTime? SAL_ATUALIZACAO { get; set; }

	public int? SAL_ASSINA { get; set; }

	public double? SAL_INICIAL { get; set; }

	public double? SAL_ESTOQUE_PADRAO { get; set; }

	public double? SAL_RESERVADO { get; set; }

	public virtual MATERIAIS MATERIAIS { get; set; }

	public virtual FILIAL FILIAL { get; set; }

	[NotMapped]
	public bool? REF_NAO_CONTROLA { get; set; }
}
