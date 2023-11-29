using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class VALES
{
	[StringLength(6)]
	public string VAL_NUMERO { get; set; }

	public short? VAL_FILIAL { get; set; }

	public double? VAL_VALOR { get; set; }

	public DateTime? VAL_DATA { get; set; }

	public byte? VAL_TIPO { get; set; }

	public DateTime? VAL_DATA_USO { get; set; }

	public byte? VAL_REDE { get; set; }

	[StringLength(16)]
	public string VAL_CODIGON { get; set; }

	public bool? VAL_EXCLUIDO { get; set; }

	public DateTime? VAL_D_EXCLUIDO { get; set; }

	[StringLength(8)]
	public string VAL_MATRICULA { get; set; }

	public DateTime? VAL_ATUALIZACAO { get; set; }

	[Key]
	[StringLength(12)]
	public string VAL_DOC { get; set; }

	[StringLength(20)]
	public string VAL_DOC_SAIDA { get; set; }

	[StringLength(20)]
	public string VAL_DOC_ENTRADA { get; set; }

	public short? VAL_FILIAL_CADASTRO { get; set; }

	public byte? VAL_NAO_DISTRIBUIR { get; set; }
}
