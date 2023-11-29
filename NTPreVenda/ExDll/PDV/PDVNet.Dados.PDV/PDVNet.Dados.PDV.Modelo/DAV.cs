using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DAV")]
public class DAV
{
	[Key]
	[StringLength(13)]
	public string DAV_DOC { get; set; }

	public byte? DAV_TIPO { get; set; }

	public int? DAV_FILIAL { get; set; }

	[StringLength(1)]
	public string DAV_CAIXA { get; set; }

	public double? DAV_VALOR { get; set; }

	[StringLength(20)]
	public string DAV_DOC_CAIXA { get; set; }

	public byte? DAV_STATUS { get; set; }

	[StringLength(100)]
	public string DAV_NOME { get; set; }

	public DateTime? DAV_DATA { get; set; }

	public byte? DAV_TABELA { get; set; }

	[StringLength(8)]
	public string DAV_VENDEDOR { get; set; }

	[StringLength(16)]
	public string DAV_CODIGON { get; set; }

	public short? DAV_CONDICAO { get; set; }

	public byte? DAV_TIPO_DESCONTO { get; set; }

	public double? DAV_DESCONTO { get; set; }

	[StringLength(8)]
	public string DAV_MATRICULA_AUTORIZA { get; set; }

	[StringLength(255)]
	public string DAV_OBSERVACAO { get; set; }

	public double? DAV_BONUS { get; set; }

	public bool DAV_CONFERIDO { get; set; }

	[StringLength(8)]
	public string DAV_MATRICULA { get; set; }

	public short DAV_PARCELAS { get; set; }

	public virtual ICollection<DAV_ITENS> DAV_ITENS { get; set; }

	public virtual ICollection<DAVBONUS> DAVBONUS { get; set; }

	public CLIENTES CLIENTES { get; set; }
}
