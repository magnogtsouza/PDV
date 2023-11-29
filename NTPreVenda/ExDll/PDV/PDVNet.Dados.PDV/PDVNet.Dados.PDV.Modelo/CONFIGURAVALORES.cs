using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class CONFIGURAVALORES
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int COV_FILIAL { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte COV_REDE { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte COV_FORMA { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte COV_PARCELA { get; set; }

	public double? COV_MINIMO { get; set; }
}
