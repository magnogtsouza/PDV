using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class REGRAS
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public short REG_CODIGO { get; set; }

	public short? REG_TELA { get; set; }

	[StringLength(50)]
	public string REG_DESCRICAO { get; set; }

	[StringLength(255)]
	public string REG_MENSAGEM { get; set; }

	public byte? REG_STATUS { get; set; }

	[StringLength(8)]
	public string REG_MATRICULA { get; set; }

	public DateTime? REG_ATUALIZACAO { get; set; }

	public byte? REG_TIPO_REGRA { get; set; }
}
