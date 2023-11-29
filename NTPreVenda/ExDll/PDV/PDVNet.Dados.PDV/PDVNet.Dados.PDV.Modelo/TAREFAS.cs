using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class TAREFAS
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short TAR_CODIGO { get; set; }

	[StringLength(30)]
	public string TAR_DESCRICAO { get; set; }

	public DateTime? TAR_CADASTRO { get; set; }

	public DateTime? TAR_ATUALIZACAO { get; set; }

	public DateTime? TAR_INICIO { get; set; }

	public DateTime? TAR_FINAL { get; set; }

	public DateTime? TAR_INTERVALO { get; set; }

	public byte? TAR_TIPO_LOJAS { get; set; }

	public byte? TAR_DIA { get; set; }

	public byte? TAR_REDE { get; set; }

	public bool? TAR_INATIVA { get; set; }

	public short? TAR_FILIAL { get; set; }
}
