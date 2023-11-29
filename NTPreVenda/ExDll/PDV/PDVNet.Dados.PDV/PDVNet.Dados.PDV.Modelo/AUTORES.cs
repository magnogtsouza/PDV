using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class AUTORES
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short AUT_CODIGO { get; set; }

	[StringLength(50)]
	public string AUT_NOME { get; set; }

	public DateTime? AUT_D_CADASTRO { get; set; }

	public DateTime? AUT_D_ATUALIZACAO { get; set; }

	public bool? AUT_INATIVO { get; set; }
}
