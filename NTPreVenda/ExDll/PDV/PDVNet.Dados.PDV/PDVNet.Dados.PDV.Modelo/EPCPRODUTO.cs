using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("EPCPRODUTO")]
public class EPCPRODUTO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int EPC_ID { get; set; }

	public int? EPC_ID_RETAGUARDA { get; set; }

	[StringLength(24)]
	public string EPC_EPC { get; set; }

	[StringLength(14)]
	public string EPC_PRODUTO { get; set; }

	public byte? EPC_STATUS { get; set; }

	public short? EPC_FILIAL { get; set; }

	public DateTime? EPC_VALIDADE { get; set; }

	public DateTime? EPC_ATUALIZACAO { get; set; }

	public DateTime? EPC_CADASTRO { get; set; }
}
