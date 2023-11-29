using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using PDVNet.Util;

namespace PDVNet.Dados.PDV.Modelo;

public class USUARIOS
{
	[Key]
	[StringLength(8)]
	public string US_MATRICULA { get; set; }

	[StringLength(30)]
	public string US_NOME { get; set; }

	[StringLength(50)]
	public string US_SENHA { get; set; }

	[StringLength(10)]
	public string US_ABREVIADO { get; set; }

	public DateTime? US_CADASTRO { get; set; }

	public short? US_FILIAL { get; set; }

	public bool? US_STATUS { get; set; }

	public byte? US_ZOOM { get; set; }

	public DateTime? US_ATUALIZACAO { get; set; }

	[StringLength(30)]
	public string US_DEPTO { get; set; }

	public bool? US_GERAL2 { get; set; }

	public short? US_REPRESENTANTE { get; set; }

	public short? US_CODIGO_WEB { get; set; }

	[StringLength(70)]
	public string US_CHAVE_WEB { get; set; }

	[StringLength(50)]
	public string US_EMAIL { get; set; }

	public bool? US_ESTOQUISTA { get; set; }

	[StringLength(8)]
	public string US_MATRICULA2 { get; set; }

	[NotMapped]
	public virtual ICollection<USUARIOACESSO> USUARIOACESSO { get; set; }

	[NotMapped]
	public short FilialRelacionadaRepresentante { get; set; }

	[NotMapped]
	public string FuncionarioAssociado { get; set; }

	[NotMapped]
	public string VendedorAssociado { get; set; }

	//[NotMapped]
	//public FiltroPDV FiltrosPorUsuario { get; set; } = new FiltroPDV();

}
