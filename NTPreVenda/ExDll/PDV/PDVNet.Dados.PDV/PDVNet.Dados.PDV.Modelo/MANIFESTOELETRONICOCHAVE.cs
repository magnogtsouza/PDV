using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
///using PDVNet.Util;

namespace PDVNet.Dados.PDV.Modelo;

[Table("MANIFESTOELETRONICOCHAVE")]
public class MANIFESTOELETRONICOCHAVE
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string MEC_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(50)]
	public string MEC_CHAVE { get; set; }

	public double? MEC_VALOR { get; set; }

	public double? MEC_PESO { get; set; }

	public int? MEC_MUNICIPIO { get; set; }

	//[NotMapped]
	//public byte CodigoEstado => MEC_MUNICIPIO.ReceberString().Mid(0, 2).ReceberByte();
}
