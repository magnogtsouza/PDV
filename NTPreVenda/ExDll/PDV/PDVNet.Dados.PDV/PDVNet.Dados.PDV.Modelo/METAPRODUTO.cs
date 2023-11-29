using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("METAPRODUTO")]
public class METAPRODUTO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short MEP_CODIGO { get; set; }

	public DateTime? MEP_INICIO { get; set; }

	public DateTime? MEP_FIM { get; set; }

	public byte? MEP_TIPO { get; set; }

	public DateTime? MEP_CADASTRO { get; set; }

	public DateTime? MEP_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string MEP_MATRICULA { get; set; }

	public byte? MEP_UNICO { get; set; }

	public bool? MEP_INATIVO { get; set; }
}
