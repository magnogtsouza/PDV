using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("COMPRADOR")]
public class COMPRADOR
{
	[Key]
	public short COM_CODIGO { get; set; }

	[StringLength(30)]
	public string COM_DESCRICAO { get; set; }

	public byte? COM_REDE { get; set; }

	public bool? COM_INATIVO2 { get; set; }

	public DateTime? COM_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string COM_MATRICULA { get; set; }
}
