using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("REQUISICAOFILA")]
public class REQUISICAOFILA
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int REF_ID { get; set; }

	public byte? REF_TIPO { get; set; }

	public string REF_BODY { get; set; }

	public string REF_PARAMETROS_HEADER { get; set; }

	public byte? REF_TENTATIVA { get; set; }

	public bool? REF_ENVIADO { get; set; }

	public DateTime? REF_CADASTRO { get; set; }

	public DateTime? REF_ATUALIZACAO { get; set; }
}
