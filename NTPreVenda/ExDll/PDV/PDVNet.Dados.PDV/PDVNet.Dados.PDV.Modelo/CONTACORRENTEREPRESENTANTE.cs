using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CONTACORRENTEREPRESENTANTE")]
public class CONTACORRENTEREPRESENTANTE
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int CCR_CODIGO { get; set; }

	public short? CCR_REPRESENTANTE { get; set; }

	[StringLength(6)]
	public string CCR_PEDIDO { get; set; }

	public double? CCR_VALOR { get; set; }

	public DateTime? CCR_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string CCR_MATRICULA { get; set; }
}
