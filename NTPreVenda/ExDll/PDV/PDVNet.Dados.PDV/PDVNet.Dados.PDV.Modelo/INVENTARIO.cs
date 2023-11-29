using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("INVENTARIO")]
public class INVENTARIO
{
	[NotMapped]
	public List<GRUPO_INVENTARIO> ExtensaoGruposInventario { get; set; }

	[Key]
	[Column(Order = 0)]
	public short INV_CODIGO { get; set; }

	public DateTime? INV_INICIO { get; set; }

	[StringLength(20)]
	public string INV_RESPONSAVEL { get; set; }

	public DateTime? INV_CADASTRO { get; set; }

	public double? INV_PECAS { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short INV_FILIAL { get; set; }

	public DateTime? INV_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string INV_MATRICULA { get; set; }

	public short? INV_LIVRO_FISCAL { get; set; }

	public bool? INV_TOTAL2 { get; set; }

	public bool? INV_PROCESSADO2 { get; set; }

	public bool? INV_ATIVO2 { get; set; }

	public byte? INV_FILTRO { get; set; }

	public DateTime? INV_REPROCESSAMENTO { get; set; }

	public bool? INV_WMS { get; set; }

	[NotMapped]
	public List<ITENSINVENTARIO> ITENSINVENTARIO { get; set; }

	[NotMapped]
	public List<WMSITENSINVENTARIO> WMSITENSINVENTARIO { get; set; }

	[NotMapped]
	public bool? FIL_DIVERGENCIA { get; set; }

	[NotMapped]
	public DateTime? Limite { get; set; }

	[NotMapped]
	public bool? FIL_GRADESEPARACAO { get; set; }

	public int? FIL_EMPRESA { get; set; }

	[NotMapped]
	public List<GRUPO_INVENTARIO> GRUPO_INVENTARIO { get; set; }

	[NotMapped]
	public List<INVENTARIOPARCIALPRODUTO> INVENTARIOPARCIALPRODUTO { get; set; }

	[NotMapped]
	public string FiltroParcial { get; set; } = "";


	[NotMapped]
	public DateTime? DataAnterior { get; set; }
}
