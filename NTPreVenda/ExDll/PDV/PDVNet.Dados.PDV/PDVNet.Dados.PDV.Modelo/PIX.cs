using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class PIX
{
	[Key]
	public Guid PIX_GUID { get; set; }

	public byte? PIX_TIPO_CHAVE { get; set; }

	[Column(TypeName = "varchar(MAX)")]
	public string PIX_CHAVE { get; set; }

	[StringLength(8)]
	public string PIX_MATRICULA { get; set; }

	public DateTime? PIX_CADASTRO { get; set; }

	public DateTime? PIX_ATUALIZACAO { get; set; }

	public bool? PIX_INATIVO { get; set; }

	public short? PIX_CONTA_CORRENTE { get; set; }

	public bool? PIX_TEF { get; set; }

	public bool? PIX_MATERA { get; set; }
}
