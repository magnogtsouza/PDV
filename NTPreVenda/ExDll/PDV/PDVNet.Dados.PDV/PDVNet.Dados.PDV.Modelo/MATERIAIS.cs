using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class MATERIAIS
{
	[NotMapped]
	public string ExtensaoCorDescricao { get; set; }

	[NotMapped]
	public string ExtensaoCorCodigoExterno { get; set; }

	[NotMapped]
	public string ExtensaoTamanhoDescricao { get; set; }

	[NotMapped]
	public double ExtensaoPreco { get; set; }

	[Key]
	[StringLength(14)]
	public string MAT_CODIGO { get; set; }

	[StringLength(12)]
	public string MAT_REFERENCIA { get; set; }

	public short? MAT_COR { get; set; }

	public short? MAT_TAMANHO { get; set; }

	public short? MAT_COLECAO { get; set; }

	public DateTime? MAT_CADASTRO { get; set; }

	public byte? MAT_REDE { get; set; }

	public DateTime? MAT_ATUALIZACAO { get; set; }

	public bool? MAT_INATIVO { get; set; }

	public short? MAT_COR_SEQ { get; set; }

	public byte? MAT_SITE { get; set; }

	[StringLength(14)]
	public string MAT_EAN { get; set; }

	public double? MAT_DESCONTO_MAXIMO { get; set; }

	public virtual REFERENCIAS REFERENCIAS { get; set; }

	public virtual CORES CORES { get; set; }

	public virtual TAMANHOS TAMANHOS { get; set; }

	public virtual ICollection<PRECO> PRECO { get; set; }

	public virtual ICollection<SALDOS> SALDOS { get; set; }

	public virtual ICollection<MATERIAISPROMOCAO> MATERIAISPROMOCAO { get; set; }
}
