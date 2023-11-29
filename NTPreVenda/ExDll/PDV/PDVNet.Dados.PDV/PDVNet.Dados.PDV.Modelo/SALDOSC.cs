using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SALDOSC")]
public class SALDOSC
{
	[Key]
	[Column(Order = 0)]
	[StringLength(14)]
	public string SAL_PRODUTO { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int SAL_FILIAL { get; set; }

	public double? SAL_SALDO { get; set; }

	public double? SAL_TRANSITO { get; set; }
}
