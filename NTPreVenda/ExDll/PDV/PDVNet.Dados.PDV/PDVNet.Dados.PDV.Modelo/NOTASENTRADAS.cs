using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class NOTASENTRADAS
{
	[StringLength(9)]
	public string NOT_NOTA { get; set; }

	[StringLength(6)]
	public string NOT_FORNECEDOR { get; set; }

	public int? NOT_FILIAL { get; set; }

	public DateTime? NOT_EMISSAO { get; set; }

	public double? NOT_VALOR { get; set; }

	public double? NOT_DESCONTO { get; set; }

	public double? NOT_PARCELAS { get; set; }

	[StringLength(8)]
	public string NOT_USUARIO { get; set; }

	public DateTime? NOT_CADASTRO { get; set; }

	public double? NOT_IPI { get; set; }

	public double? NOT_PRODUTOS { get; set; }

	public DateTime? NOT_ENTRADA { get; set; }

	public byte? NOT_TIPO_DESCONTO { get; set; }

	public DateTime? NOT_ATUALIZACAO { get; set; }

	[StringLength(150)]
	public string NOT_OBS { get; set; }

	public double? NOT_DEVOLVIDA { get; set; }

	public double? NOT_CREDITO { get; set; }

	public byte? NOT_GRADE { get; set; }

	public byte? NOT_GERAR_CREDITO { get; set; }

	public double? NOT_MINIMO { get; set; }

	public byte? NOT_TIPO_MINIMO { get; set; }

	public byte? NOT_TIPO_DESCONTO2 { get; set; }

	public DateTime? NOT_ENTRADA2 { get; set; }

	public byte? NOT_SISTEMA2 { get; set; }

	public double? NOT_GERENCIAL { get; set; }

	[Key]
	[StringLength(20)]
	public string NOT_DOC { get; set; }

	public byte? NOT_EXCLUIDA { get; set; }

	public short? NOT_FILIAL_ALTERACAO { get; set; }

	public byte? NOT_TIPO { get; set; }

	public short? NOT_CFOP { get; set; }

	[StringLength(3)]
	public string NOT_SERIE { get; set; }

	public double? NOT_BASEICMS { get; set; }

	public double? NOT_VALORICMS { get; set; }

	public double? NOT_BASESUB { get; set; }

	public double? NOT_VALORSUB { get; set; }

	public double? NOT_FRETE { get; set; }

	public byte? NOT_GERA_CREDITO2 { get; set; }

	[StringLength(2)]
	public string NOT_MODELO { get; set; }

	public byte? NOT_TEM_CONHECIMENTO { get; set; }

	public byte? NOT_TIPO_FRETE { get; set; }

	[StringLength(50)]
	public string NOT_NFE_CHAVE { get; set; }
}
