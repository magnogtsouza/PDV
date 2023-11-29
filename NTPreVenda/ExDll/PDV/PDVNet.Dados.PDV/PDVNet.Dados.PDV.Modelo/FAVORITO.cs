using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FAVORITO")]
public class FAVORITO
{
	[Key]
	[StringLength(6)]
	public string FAV_CODIGO { get; set; }

	[StringLength(40)]
	public string FAV_DESCRICAO { get; set; }

	public byte? FAV_RELATORIO { get; set; }

	public byte? FAV_NIVEL { get; set; }

	[StringLength(8)]
	public string FAV_MATRICULA { get; set; }

	public byte? FAV_CUSTO { get; set; }

	public byte? FAV_TABELA1 { get; set; }

	public byte? FAV_TABELA2 { get; set; }

	public byte? FAV_TABELA3 { get; set; }

	public byte? FAV_TABELA4 { get; set; }

	public byte? FAV_TABELA5 { get; set; }

	public byte? FAV_TOTALIZAR1 { get; set; }

	public byte? FAV_TOTALIZAR2 { get; set; }

	public byte? FAV_TOTALIZAR3 { get; set; }

	public byte? FAV_ORDENAR { get; set; }

	public byte? FAV_ESTOQUE { get; set; }

	public DateTime? FAV_DATA1 { get; set; }

	public DateTime? FAV_DATA2 { get; set; }

	public DateTime? FAV_DATA3 { get; set; }

	public DateTime? FAV_DATA4 { get; set; }

	public DateTime? FAV_DATA5 { get; set; }

	public DateTime? FAV_DATA6 { get; set; }

	public byte? FAV_VENDA { get; set; }

	public bool? FAV_INATIVO { get; set; }

	public byte? FAV_DIVERSOS { get; set; }

	public byte? FAV_DIVERSOS2 { get; set; }

	public byte? FAV_LIQUIDACAO { get; set; }

	public byte? FAV_TIPO { get; set; }

	public byte? FAV_TIPO_DATA { get; set; }

	[StringLength(50)]
	public string FAV_ARQUIVO { get; set; }

	public byte? FAV_TIPO_LOJA { get; set; }
}
