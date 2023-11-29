using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class PROMOCAOPECAS
{
	[Key]
	[Column(Order = 0)]
	public short PRP_PROMOCAO { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte PRP_PECA { get; set; }

	public double? PRP_DESCONTO { get; set; }
}
