using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ARQUIVOENTIDADE")]
public class ARQUIVOENTIDADE
{
	[Key]
	[Column(Order = 0)]
	public short ARE_CODIGO { get; set; }

	public byte? ARE_NEGOCIO { get; set; }

	public short? ARE_ENTIDADE { get; set; }

	public bool? ARE_INATIVO { get; set; }

	public DateTime? ARE_ATUALIZACAO { get; set; }
}
