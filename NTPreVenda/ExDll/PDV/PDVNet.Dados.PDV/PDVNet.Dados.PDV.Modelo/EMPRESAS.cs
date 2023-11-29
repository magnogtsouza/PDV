using System;
using System.ComponentModel.DataAnnotations;
//using PDVNet.Util;

namespace PDVNet.Dados.PDV.Modelo;

public class EMPRESAS
{
	[Key]
	public byte EMP_CODIGO { get; set; }

	[StringLength(45)]
	public string EMP_RAZAO_SOCIAL { get; set; }

	[StringLength(20)]
	public string EMP_COMPOSICAO { get; set; }

	public byte? EMP_TAMANHO { get; set; }

	[StringLength(8)]
	public string EMP_SEQ { get; set; }

	[StringLength(1)]
	public string EMP_RAMO { get; set; }

	[StringLength(10)]
	public string EMP_COMPOSICAO_BARRA { get; set; }

	public byte? EMP_TAMANHO_BARRA { get; set; }

	public byte? EMP_PRECO_DECIMAL { get; set; }

	public byte? EMP_COMPOSTA2 { get; set; }

	public byte? EMP_UNICA2 { get; set; }

	public byte? EMP_ARREDONDA2 { get; set; }

	public byte? EMP_PRECO2 { get; set; }

	public byte? EMP_FORMATA2 { get; set; }

	public byte? EMP_PROPRIA2 { get; set; }

	[StringLength(100)]
	public string EMP_DIR_FOTOS { get; set; }

	public byte? EMP_QTD { get; set; }

	public byte? EMP_ATACADO { get; set; }

	public byte? EMP_COMUNICACAO { get; set; }

	public byte? EMP_PEDIDO { get; set; }

	public byte? EMP_DISTRIBUICAO { get; set; }

	public byte? EMP_COR_FORNECEDOR { get; set; }

	public byte? EMP_FIDELIDADE { get; set; }

	public byte? EMP_GRADE { get; set; }

	public byte? EMP_ULT_VENDEDOR { get; set; }

	public byte? EMP_ULT_FILIAL { get; set; }

	public bool? EMP_INATIVA { get; set; }

	public DateTime? EMP_CADASTRO { get; set; }

	public DateTime? EMP_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string EMP_MATRICULA { get; set; }

	public byte? EMP_INVENTARIO { get; set; }

	public byte? EMP_HISTORICO { get; set; }

	public byte? EMP_SEQUENCIAL { get; set; }

	public byte? EMP_ESTOQUE_NEGATIVO { get; set; }

	public byte? EMP_HABILITA_QUANTIDADE { get; set; }

	public byte? EMP_BLOQUEAR_PEDIDO { get; set; }

	public byte? EMP_QUANTIDADE_BALANCA { get; set; }

	//public enumRamo PegarRamo()
	//{
	//	return EMP_RAMO.ReceberString() switch
	//	{
	//		"D" => enumRamo.Decoracao, 
	//		"E" => enumRamo.Escolas, 
	//		"J" => enumRamo.Joias, 
	//		"L" => enumRamo.Livrarias, 
	//		_ => enumRamo.Roupas, 
	//	};
	//}

	//public bool ValidarGrade()
	//{
	//	if (EMP_COMPOSICAO.ReceberString().ToLower().IndexOf("s") < 0 && EMP_COMPOSICAO.ReceberString().ToLower().IndexOf("x") < 0 && EMP_GRADE.ReceberByte() == 1)
	//	{
	//		return true;
	//	}
	//	return false;
	//}
}
