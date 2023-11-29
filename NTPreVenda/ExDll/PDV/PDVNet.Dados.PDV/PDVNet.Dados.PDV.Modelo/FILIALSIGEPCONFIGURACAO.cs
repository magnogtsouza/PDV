using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILIALSIGEPCONFIGURACAO")]
public class FILIALSIGEPCONFIGURACAO
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short? FSC_FILIAL { get; set; }

	[StringLength(20)]
	public string FSC_USUARIO { get; set; }

	[StringLength(20)]
	public string FSC_SENHA { get; set; }

	[StringLength(10)]
	public string FSC_CONTRATO { get; set; }

	[StringLength(10)]
	public string FSC_CODIGO_ADMINISTRATIVO { get; set; }

	[StringLength(10)]
	public string FSC_CARTAO_POSTAGEM { get; set; }

	public DateTime? FSC_CADASTRO { get; set; }

	public DateTime? FSC_ATUALIZACAO { get; set; }

	public bool? FSC_INATIVO { get; set; }

	[StringLength(8)]
	public string FSC_MATRICULA { get; set; }
}
