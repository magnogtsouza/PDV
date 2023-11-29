using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALNFSE")]
public class FILIALNFSE
{
	[Key]
	[Column(Order = 0)]
	public short FIN_FILIAL { get; set; }

	public int? FIN_NFSE_CCM { get; set; }

	[StringLength(20)]
	public string FIN_NFSE_SENHA { get; set; }

	public short? FIN_FILIAL_EMISSAO { get; set; }

	public byte? FIN_NATUREZA_OPERACAO { get; set; }

	public short? FIN_SERVICO_SERIE { get; set; }

	public double? FIN_SERVICO_ALIQUOTA { get; set; }

	public byte? FIN_REGIME_ESPECIAL_TRIBUTACAO { get; set; }
}
