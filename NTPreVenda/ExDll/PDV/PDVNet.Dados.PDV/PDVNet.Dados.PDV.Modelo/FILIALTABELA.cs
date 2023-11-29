using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALTABELA")]
public class FILIALTABELA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short FIT_FILIAL { get; set; }

	public byte FIT_TABELA { get; set; }

	public byte? FIT_VENDA { get; set; }

	public bool? FIT_INATIVO { get; set; }

	public DateTime? FIT_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string FIT_MATRICULA { get; set; }

	public byte? FIT_CUSTO { get; set; }

	public byte? FIT_T_TRANSFERENCIA { get; set; }

	public byte? FIT_T_ENTRADA { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte FIT_SEQ { get; set; }

	public byte? FIT_T_PRODUTO { get; set; }

	public byte? FIT_T_PEDIDO { get; set; }

	public byte? FIT_T_FATURAMENTO { get; set; }

	public byte? FIT_T_INVENTARIO { get; set; }

	public byte? FIT_T_CONSULTA { get; set; }

	public byte? FIT_T_ARMAZENA { get; set; }

	public byte? FIT_T_PEDIDO_VENDA { get; set; }

	public byte? FIT_T_CONSUMO_CUSTO_MEDIO { get; set; }
}
