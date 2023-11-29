using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ENDERECO")]
public class ENDERECO
{
	[Key]
	[Column(Order = 0)]
	public byte END_TIPO_CADASTRO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(16)]
	public string END_CODIGO { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte END_SEQ { get; set; }

	public byte? END_TIPO_ENDERECO { get; set; }

	[StringLength(10)]
	public string END_CEP { get; set; }

	[StringLength(70)]
	public string END_ENDERECO { get; set; }

	[StringLength(5)]
	public string END_NUMERO { get; set; }

	[StringLength(30)]
	public string END_COMPLEMENTO { get; set; }

	[StringLength(30)]
	public string END_BAIRRO { get; set; }

	[StringLength(30)]
	public string END_CIDADE { get; set; }

	[StringLength(2)]
	public string END_UF { get; set; }

	[StringLength(70)]
	public string END_PAIS { get; set; }

	public bool? END_INATIVO { get; set; }

	public DateTime? END_CADASTRO { get; set; }

	public DateTime? END_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string END_MATRICULA { get; set; }

	public byte? END_COD_IBGE_ESTADO { get; set; }

	public short? END_COD_IBGE_PAIS { get; set; }

	public int? END_COD_IBGE_CIDADE { get; set; }

	public short? END_FILIAL_ALTERACAO { get; set; }

	public string END_CONTATO { get; set; }

	public virtual ICollection<CLIENTES> CLIENTES { get; set; }

	public virtual ICollection<FILIAL> FILIAL { get; set; }

	[NotMapped]
	public string ExtensaoReferencia { get; set; }
}
