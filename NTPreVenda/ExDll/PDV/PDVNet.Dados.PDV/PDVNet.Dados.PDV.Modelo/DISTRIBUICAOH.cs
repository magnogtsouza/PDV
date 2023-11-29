using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DISTRIBUICAOH")]
public class DISTRIBUICAOH
{
	[Key]
	[Column(Order = 0)]
	[StringLength(6)]
	public string DIH_CODIGO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short DIH_FILIAL { get; set; }

	public DateTime? DIH_CADASTRO { get; set; }

	public DateTime? DIH_ATUALIZACAO { get; set; }

	public DateTime? DIH_RECEBIMENTO { get; set; }

	public DateTime? DIH_BATIMENTO { get; set; }

	public short? DIH_FILIAL_SAIDA { get; set; }

	public byte? DIH_TELA { get; set; }

	public byte? DIH_RECEBIDO_LOJA { get; set; }

	public byte? DIH_BATIMENTO2 { get; set; }

	public bool? DIH_INATIVO { get; set; }

	[StringLength(8)]
	public string DIH_MATRICULA { get; set; }

	public byte? DIH_ESTOQUE { get; set; }

	[NotMapped]
	public double? DIS_QUANTIDADE { get; set; }

	[NotMapped]
	public double? DIS_RECEBIDA { get; set; }

	[NotMapped]
	public string DIS_PRODUTO { get; set; }

	[NotMapped]
	public string DIS_RAZAO { get; set; }

	public List<DISTRIBUICAO> ExtensaoItens { get; set; }
}
