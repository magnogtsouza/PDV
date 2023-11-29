using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ULTIMAVERSAO")]
public class ULTIMAVERSAO
{
	[Key]
	[Column(Order = 0)]
	[StringLength(200)]
	public string UVE_ARQUIVO { get; set; }

	public byte? UVE_TIPO_SISTEMA { get; set; }

	public DateTime? UVE_DATA_ATUALIZACAO { get; set; }
}
