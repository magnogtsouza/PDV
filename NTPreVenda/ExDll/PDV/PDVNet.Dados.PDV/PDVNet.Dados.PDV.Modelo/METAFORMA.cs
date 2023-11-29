using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("METAFORMA")]
public class METAFORMA
{
	[Key]
	public short MET_CODIGO { get; set; }

	public DateTime? MET_INICIO { get; set; }

	public DateTime? MET_FIM { get; set; }

	public DateTime? MET_CADASTRO { get; set; }

	public DateTime? MET_ATUALIZACAO { get; set; }

	public short? MET_FILIAL { get; set; }

	[StringLength(8)]
	public string MET_MATRICULA { get; set; }

	public bool? MET_INATIVA { get; set; }

	public double? MET_DINHEIRO { get; set; }

	public double? MET_CHEQUE { get; set; }

	public double? MET_PRE { get; set; }

	public double? MET_DEBITO { get; set; }

	public double? MET_ROTATIVO { get; set; }

	public double? MET_PARCELADO { get; set; }

	public double? MET_CREDIARIO { get; set; }
}
