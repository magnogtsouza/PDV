using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ENVIOARQUIVO")]
public class ENVIOARQUIVO
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int ENV_FILIAL { get; set; }

	public DateTime? ENV_DATA_ENVIO { get; set; }

	[StringLength(255)]
	public string ENV_DADOS { get; set; }

	public DateTime? ENV_HORA { get; set; }

	public DateTime? ENV_DATA1 { get; set; }

	public DateTime? ENV_DATA2 { get; set; }

	[StringLength(8)]
	public string ENV_MATRICULA { get; set; }

	public DateTime? ENV_DATA_RECEBIMENTO { get; set; }

	public DateTime? ENV_HORA_RECEBIMENTO { get; set; }

	public byte? ENV_VEZES { get; set; }

	public byte? ENV_SISTEMA_ENVIO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(20)]
	public string ENV_DOC { get; set; }

	public DateTime? ENV_VERSAO { get; set; }

	public int? ENV_ORIGEM { get; set; }

	public byte? ENV_ERRO { get; set; }

	public byte? ENV_TIPO_ARQUIVO { get; set; }
}
