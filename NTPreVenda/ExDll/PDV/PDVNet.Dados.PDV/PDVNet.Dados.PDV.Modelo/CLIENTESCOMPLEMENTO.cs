using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("CLIENTESCOMPLEMENTO")]
public class CLIENTESCOMPLEMENTO
{
	[Key]
	[StringLength(16)]
	public string CLC_CODIGON { get; set; }

	[StringLength(100)]
	public string CLC_FANTASIA { get; set; }

	[StringLength(30)]
	public string CLC_INSCRICAO { get; set; }

	[StringLength(150)]
	public string CLC_REFERENCIA1 { get; set; }

	[StringLength(30)]
	public string CLC_CONTATO_REF1 { get; set; }

	[StringLength(5)]
	public string CLC_DDD_REF1 { get; set; }

	[StringLength(30)]
	public string CLC_TEL_REF1 { get; set; }

	[StringLength(150)]
	public string CLC_REFERENCIA2 { get; set; }

	[StringLength(30)]
	public string CLC_CONTATO_REF2 { get; set; }

	[StringLength(5)]
	public string CLC_DDD_REF2 { get; set; }

	[StringLength(30)]
	public string CLC_TEL_REF2 { get; set; }

	[StringLength(150)]
	public string CLC_REFERENCIA3 { get; set; }

	[StringLength(30)]
	public string CLC_CONTATO_REF3 { get; set; }

	[StringLength(5)]
	public string CLC_DDD_REF3 { get; set; }

	[StringLength(30)]
	public string CLC_TEL_REF3 { get; set; }

	[StringLength(20)]
	public string CLC_CONTATO1 { get; set; }

	[StringLength(20)]
	public string CLC_CONTATO2 { get; set; }

	[StringLength(30)]
	public string CLC_COMPRA_REF1 { get; set; }

	[StringLength(30)]
	public string CLC_COMPRA_REF2 { get; set; }

	[StringLength(30)]
	public string CLC_COMPRA_REF3 { get; set; }

	public byte? CLC_TIPO { get; set; }

	public byte? CLC_PRIORIDADE { get; set; }

	public short? CLC_FILIAL { get; set; }

	public byte? CLC_PED_COMPRA { get; set; }

	public double? CLC_MINIMO { get; set; }

	public byte? CLC_DUPLICATA { get; set; }

	public short? CLC_TRANSPORTADORA { get; set; }

	public byte? CLC_FRETE { get; set; }

	[StringLength(255)]
	public string CLC_OBS_F { get; set; }

	public byte? CLC_ICMS { get; set; }

	public double? CLC_DESCONTO { get; set; }

	public short? CLC_NATUREZA { get; set; }

	public byte? CLC_CREDITO { get; set; }

	public short? CLC_REPRESENTANTE { get; set; }

	public byte? CLC_TABELA { get; set; }

	[StringLength(9)]
	public string CLC_SUFRAMA { get; set; }

	public short? CLC_CONDICAO { get; set; }

	public short? TIPO_SERVICO { get; set; }

	public bool? CLC_ENVIAR_EAN { get; set; }

	public short? CLC_STATUS { get; set; }

	public double? CLC_VALOR_SERVICO { get; set; }

	public short? CLC_TIPO_SERVICO { get; set; }

	public byte? CLC_REGIME { get; set; }
}
