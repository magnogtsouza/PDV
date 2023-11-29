using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CORESBASICAS
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int COB_CODIGO { get; set; }

	[StringLength(30)]
	public string COB_DESCRICAO { get; set; }

	public bool? COB_INATIVA { get; set; }

	public DateTime? COB_CADASTRO { get; set; }

	public DateTime? COB_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string COB_MATRICULA { get; set; }

	[StringLength(20)]
	public string COB_RGB { get; set; }
}
