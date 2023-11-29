using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class ARQUIVOCNABCAMPO
{
	[Key]
	public short ACC_CODIGO { get; set; }

	[Key]
	public byte ACC_CAMPO { get; set; }

	public short? ACC_INICIO { get; set; }

	public short? ACC_FIM { get; set; }

	public byte? ACC_TIPO { get; set; }

	public string ACC_VALOR_PADRAO { get; set; }

	public string ACC_CAMPO_BANCO { get; set; }

	public DateTime? ACC_ATUALIZACAO { get; set; }

	public bool? ACC_INATIVO { get; set; }

	public string ACC_DESCRICAO { get; set; }

	[NotMapped]
	public dynamic ValorArquivo { get; set; }
}
