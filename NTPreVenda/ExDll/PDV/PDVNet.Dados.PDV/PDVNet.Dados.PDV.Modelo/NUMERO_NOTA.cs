using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class NUMERO_NOTA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short PRI_FILIAL { get; set; }

	[StringLength(9)]
	public string PRI_NOTA { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short PRI_SERIE { get; set; }

	public bool? PRI_INATIVO { get; set; }

	public bool? PRI_VALIDO_LOJA { get; set; }

	public DateTime? PRI_ATUALIZACAO { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte? PRI_TIPO_NF { get; set; }
}
