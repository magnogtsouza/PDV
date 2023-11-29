using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FORMAPAGAMENTO")]
public class FORMAPAGAMENTO
{
	[Key]
	public byte? FOR_CODIGO { get; set; }

	[StringLength(30)]
	public string FOR_DESCRICAO { get; set; }

	[StringLength(20)]
	public string FOR_IMAGEM { get; set; }

	public bool? FOR_INATIVA { get; set; }

	public DateTime? FOR_ATUALIZACAO { get; set; }

	public byte? FOR_LINHA { get; set; }

	public bool? FOR_APARECE { get; set; }

	public byte? FOR_FORMA { get; set; }
}
