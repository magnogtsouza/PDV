using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("VENDASENTREGA")]
public class VENDASENTREGA
{
	[Key]
	[Column(Order = 0)]
	[StringLength(20)]
	public string VEE_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public int VEE_ITEM { get; set; }

	public DateTime? VEE_DATA { get; set; }

	[StringLength(16)]
	public string VEE_ENDERECO { get; set; }

	public byte? VEE_SEPARADO { get; set; }

	public byte? VEE_TIPO_CADASTRO { get; set; }

	public byte? VEE_SEQ { get; set; }

	[StringLength(16)]
	public string VEE_CHAVE { get; set; }

	public short VEE_TRANSPORTADORA { get; set; }

	public short? VEE_OBS { get; set; }

	public short? VEE_FILIAL_ESTOQUE { get; set; }

	public byte? VEE_TIPO_ENTREGA { get; set; }

	[StringLength(15)]
	public string VEE_PEDIDO { get; set; }

	public double? VEE_QTD_RESERVADA { get; set; }

	public byte? VEE_SERVICO_TRANSPORTADORA { get; set; }
}
