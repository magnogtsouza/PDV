using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class IMPRESSAOFILA
{
	[Key]
	public int IFI_SEQ { get; set; }

	public Guid? IFI_COMPUTADOR { get; set; }

	public byte? IFI_TIPO { get; set; }

	[StringLength(50)]
	public string IFI_DOC { get; set; }

	public DateTime? IFI_CADASTRO { get; set; }

	public DateTime? IFI_ATUALIZACAO { get; set; }

	public short? IFI_STATUS { get; set; }

	public short? IFI_FILIAL { get; set; }

	[NotMapped]
	public string STA_DESCRICAO { get; set; }
}
