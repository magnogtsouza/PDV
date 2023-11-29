using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CARTEIRACOBRANCA")]
public class CARTEIRACOBRANCA
{
	[Key]
	public byte CCB_CODIGO { get; set; }

	[StringLength(255)]
	public string CCB_DESCRICAO { get; set; }

	public DateTime? CCB_ATUALIZACAO { get; set; }

	public byte? CCB_ACAO { get; set; }

	public bool? CCB_INATIVO { get; set; }
}
