using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("NF_REGRACFOP")]
public class NF_REGRACFOP
{
	[Key]
	public short NRC_CODIGO { get; set; }

	public short? NRC_NATUREZAOPERACAO { get; set; }

	public short? NRC_TIPOPRODUTO { get; set; }

	public short? NRC_TIPOPESSOA { get; set; }

	public short? NRC_CFOP_DENTRO { get; set; }

	public short? NRC_CFOP_FORA { get; set; }

	public short? NRC_CFOP_EXTERIOR { get; set; }

	public DateTime? NRC_CADASTRO { get; set; }

	public DateTime? NRC_ATUALIZACAO { get; set; }

	public string NRC_MATRICULA { get; set; }

	public bool? NRC_INATIVO { get; set; }
}
