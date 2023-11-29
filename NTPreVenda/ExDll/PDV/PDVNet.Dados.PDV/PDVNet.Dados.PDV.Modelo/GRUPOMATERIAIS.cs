using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class GRUPOMATERIAIS
{
	[Key]
	public short GRUM_CODIGO { get; set; }

	[StringLength(30)]
	public string GRUM_DESCRICAO { get; set; }

	public byte? GRUM_REDE { get; set; }

	public bool? GRUM_INATIVO2 { get; set; }

	[StringLength(3)]
	public string GRUM_PREFIXO { get; set; }

	public DateTime? GRUM_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string GRUM_MATRICULA { get; set; }

	public double? GRUM_MARGEM { get; set; }

	[NotMapped]
	public string US_ABREVIADO { get; set; }
}
