using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ENTRADASAIDAH")]
public class ENTRADASAIDAH
{
	public short? ENH_FILIAL_CADASTRO { get; set; }

	public DateTime? ENH_CADASTRO { get; set; }

	public DateTime? ENH_ATUALIZACAO { get; set; }

	public short? ENH_FILIAL { get; set; }

	public bool? ENH_TIPO { get; set; }

	[StringLength(8)]
	public string ENH_USUARIO { get; set; }

	public bool? ENH_EXCLUIDA { get; set; }

	[StringLength(100)]
	public string ENH_OBS { get; set; }

	public byte? ENH_TABELA { get; set; }

	[Key]
	[StringLength(20)]
	public string ENH_DOC { get; set; }

	public int? ENH_CONTAGEM { get; set; }

	public virtual List<ENTRADASAIDA> ListaItens { get; set; }
}
