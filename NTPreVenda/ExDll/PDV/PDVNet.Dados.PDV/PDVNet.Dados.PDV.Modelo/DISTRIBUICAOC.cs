using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DISTRIBUICAOC")]
public class DISTRIBUICAOC
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int DIC_CODIGO { get; set; }

	public DateTime? DIC_CADASTRO { get; set; }

	public DateTime? DIC_ATUALIZACAO { get; set; }

	[StringLength(6)]
	public string DIC_ROMANEIO { get; set; }

	public short? DIC_FILIAL { get; set; }

	[StringLength(8)]
	public string DIC_MATRICULA { get; set; }

	public bool? DIC_INATIVA { get; set; }

	[StringLength(15)]
	public string DIC_SERIAL { get; set; }
}
