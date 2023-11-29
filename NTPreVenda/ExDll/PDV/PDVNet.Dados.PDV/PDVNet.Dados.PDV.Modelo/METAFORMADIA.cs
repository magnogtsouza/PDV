using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("METAFORMADIA")]
public class METAFORMADIA
{
	[Key]
	public short MEF_CODIGO { get; set; }

	public DateTime? MEF_DIA { get; set; }

	public int? MEF_FILIAL { get; set; }
}
