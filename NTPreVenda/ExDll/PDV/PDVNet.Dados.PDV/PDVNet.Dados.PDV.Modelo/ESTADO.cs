using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("ESTADO")]
public class ESTADO
{
	[Key]
	[StringLength(2)]
	public string EST_CODIGO { get; set; }

	public double? EST_ICM { get; set; }

	public byte? EST_COD_IBGE { get; set; }

	public byte? EST_REGIAO { get; set; }

	public virtual ICollection<VEICULO> VEICULO { get; set; }
}
