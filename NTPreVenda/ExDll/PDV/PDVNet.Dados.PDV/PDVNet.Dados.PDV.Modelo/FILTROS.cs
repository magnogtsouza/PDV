using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("FILTROS")]
public class FILTROS
{
	[StringLength(6)]
	public string FIL_FAVORITO { get; set; }

	[StringLength(6)]
	public string FIL_REGISTRO { get; set; }

	[StringLength(8)]
	public string FIL_MATRICULA { get; set; }

	public byte FIL_FILTRO { get; set; }

	public byte FIL_IGUAL { get; set; }

	[StringLength(8)]
	public string FIL_CONTEUDO { get; set; }

	public short FIL_TELA { get; set; }

	public byte FIL_RELATORIO { get; set; }

	public bool? FIL_FIXO { get; set; }
}
