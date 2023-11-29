using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ESTOQUEPADRAO")]
public class ESTOQUEPADRAO
{
	[Key]
	[StringLength(8)]
	public string ESP_CODIGO { get; set; }

	[StringLength(50)]
	public string ESP_NOME { get; set; }

	public DateTime? ESP_CADASTRO { get; set; }

	public DateTime? ESP_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string ESP_MATRICULA { get; set; }

	public bool? ESP_INATIVO { get; set; }

	public byte? ESP_REDE { get; set; }
}
