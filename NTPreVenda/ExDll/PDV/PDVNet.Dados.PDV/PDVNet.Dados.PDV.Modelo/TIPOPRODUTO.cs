using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("TIPOPRODUTO")]
public class TIPOPRODUTO
{
	[Key]
	[Column(Order = 0)]
	public short TPR_CODIGO { get; set; }

	[StringLength(50)]
	public string TPR_DESCRICAO { get; set; }

	public DateTime? TPR_ATUALIZACAO { get; set; }

	public bool? TPR_INATIVO { get; set; }
}
