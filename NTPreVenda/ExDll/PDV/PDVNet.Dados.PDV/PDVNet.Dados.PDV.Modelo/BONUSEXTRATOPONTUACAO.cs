using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("BONUSEXTRATOPONTUACAO")]
public class BONUSEXTRATOPONTUACAO
{
	[Key]
	[Column(Order = 0)]
	public short BEP_REGISTRO_BONUS { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string BEP_CAIXA_DOC { get; set; }

	[Key]
	[Column(Order = 2)]
	[StringLength(20)]
	public string BEP_CODIGON { get; set; }

	public double? BEP_PONTOS { get; set; }

	public DateTime? BEP_CADASTRO { get; set; }

	public DateTime? BEP_ATUALIZACAO { get; set; }

	public DateTime? BEP_VALIDADE { get; set; }

	public bool? BEP_INATIVO { get; set; }

	public byte? BEP_STATUS { get; set; }

	[Key]
	[Column(Order = 3)]
	public byte BEP_SEQ { get; set; }

	public short? BEP_CONSUMO { get; set; }
}
