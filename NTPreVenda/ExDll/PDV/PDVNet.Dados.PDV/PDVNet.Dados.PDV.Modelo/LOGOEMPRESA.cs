using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class LOGOEMPRESA
{
	[Key]
	[Column(Order = 0)]
	public byte LOE_REDE { get; set; }

	public short LOE_FILIAL { get; set; }

	public byte[] LOE_LOGO_PRINCIPAL { get; set; }

	public byte? LOE_EXTENSAO_LOGO_PRINCIPAL { get; set; }

	public byte[] LOE_LOGO_RELATORIO { get; set; }

	public byte? LOE_EXTENSAO_LOGO_RELATORIO { get; set; }

	public DateTime? LOE_ATUALIZACAO { get; set; }
}
