using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using PDVNet.Util;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SITECATEGORIA")]
public class SITECATEGORIA
{
	public List<SITECATEGORIA> Filhos { get; set; }

	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short SCA_CODIGO { get; set; }

	[StringLength(100)]
	public string SCA_DESCRICAO { get; set; }

	public short? SCA_PAI { get; set; }

	public bool? SCA_INATIVO { get; set; }

	public DateTime? SCA_CADASTRO { get; set; }

	public DateTime? SCA_ATUALIZACAO { get; set; }

	public DateTime? SCA_ULTIMA_EXPORTACAO { get; set; }

	[StringLength(8)]
	public string SCA_MATRICULA { get; set; }

	[StringLength(255)]
	public string SCA_PALAVRAS { get; set; }

	[StringLength(255)]
	public string SCA_OBS { get; set; }

	//public override string ToString()
	//{
	//	return SCA_CODIGO.ReceberString() + " - " + SCA_DESCRICAO.ReceberString();
	//}
}
