using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NF_TIPOOPERACAO")]
public class NF_TIPOOPERACAO
{
	[Key]
	[Column(Order = 0)]
	public short NTP_CODIGO { get; set; }

	[StringLength(50)]
	public string NTP_DESCRICAO { get; set; }

	public DateTime? NTP_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string NTP_MATRICULA { get; set; }

	public bool? NTP_INATIVO { get; set; }

	[NotMapped]
	public string UsuarioNome { get; set; }
}
