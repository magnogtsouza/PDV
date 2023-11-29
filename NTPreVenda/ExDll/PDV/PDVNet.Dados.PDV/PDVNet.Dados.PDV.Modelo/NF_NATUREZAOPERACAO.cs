using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NF_NATUREZAOPERACAO")]
public class NF_NATUREZAOPERACAO
{
	[Key]
	public short NNO_CODIGO { get; set; }

	[StringLength(60)]
	public string NNO_DESCRICAO { get; set; }

	public string NNO_DESCRICAOFISCAL { get; set; }

	public byte? NNO_OPERACAO { get; set; }

	public short? NNO_TIPOOPERACAO { get; set; }

	public bool? NNO_GERAR_DUPLICATA { get; set; }

	public bool? NNO_ATUALIZAR_CUSTO { get; set; }

	public bool? NNO_ATUALIZAR_ESTOQUE { get; set; }

	public DateTime? NNO_CADASTRO { get; set; }

	public DateTime? NNO_ATUALIZACAO { get; set; }

	public string NNO_MATRICULA { get; set; }

	public bool? NNO_INATIVO { get; set; }

	public bool? NNO_COMPRA { get; set; }
}
