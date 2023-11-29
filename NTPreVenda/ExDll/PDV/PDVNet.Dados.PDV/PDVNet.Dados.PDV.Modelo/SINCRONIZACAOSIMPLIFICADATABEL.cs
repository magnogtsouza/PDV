using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("SINCRONIZACAOSIMPLIFICADATABELA")]
public class SINCRONIZACAOSIMPLIFICADATABELA
{
	[Key]
	[Column(Order = 0)]
	public short SST_TABELA { get; set; }

	public bool? SST_ATUALIZAR { get; set; }

	public DateTime? SST_ATUALIZACAO { get; set; }
}
