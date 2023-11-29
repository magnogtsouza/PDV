using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DFEFILA")]
public class DFEFILA
{
	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	[StringLength(20)]
	public string DFF_DOC { get; set; }

	[Key]
	[Column(Order = 1)]
	public byte? DFF_TIPO_DF { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte? DFF_TIPO { get; set; }

	[StringLength(15)]
	public string DFF_COMPUTADOR_SERIAL { get; set; }

	[StringLength(30)]
	public string DFF_COMPUTADOR_NOME { get; set; }

	[StringLength(50)]
	public string DFF_CHAVE { get; set; }

	public string DFF_RETORNO { get; set; }

	[StringLength(255)]
	public string DFF_OBSERVACAO { get; set; }

	public DateTime? DFF_CADASTRO { get; set; }

	public DateTime? DFF_ATUALIZACAO { get; set; }

	public byte? DFF_STATUS { get; set; }

	[StringLength(4)]
	public string DFF_VERSAO { get; set; }

	public short DFF_LOJA_SUPORTE { get; set; }
}
