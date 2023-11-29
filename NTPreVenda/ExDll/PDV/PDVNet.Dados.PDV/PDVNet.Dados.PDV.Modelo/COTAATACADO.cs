using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("COTAATACADO")]
public class COTAATACADO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short COT_CODIGO { get; set; }

	[StringLength(50)]
	public string COT_DESCRICAO { get; set; }

	[StringLength(2)]
	public string COT_TIPO_CLIENTE { get; set; }

	public DateTime? COT_INICIO { get; set; }

	public DateTime? COT_FINAL { get; set; }

	public bool? COT_INATIVO { get; set; }

	public DateTime? COT_CADASTRO { get; set; }

	public byte? COT_TAB1 { get; set; }

	public byte? COT_TAB2 { get; set; }

	public byte? COT_CONTROLA_QTD { get; set; }

	[StringLength(8)]
	public string COT_MATRICULA { get; set; }

	public DateTime? COT_ATUALIZACAO { get; set; }
}
