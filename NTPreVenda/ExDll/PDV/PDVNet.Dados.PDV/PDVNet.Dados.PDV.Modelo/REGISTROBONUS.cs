using System;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class REGISTROBONUS
{
	[Key]
	public short REG_CODIGO { get; set; }

	public DateTime? REG_INICIO { get; set; }

	public DateTime? REG_FINAL { get; set; }

	public DateTime? REG_VALIDADE { get; set; }

	public double? REG_FATOR { get; set; }

	[StringLength(8)]
	public string REG_MATRICULA { get; set; }

	public double? REG_SALDO_INICIAL { get; set; }

	public DateTime? REG_CADASTRO { get; set; }

	public bool? REG_EXCLUIDO { get; set; }

	public DateTime? REG_D_EXCLUIDO { get; set; }

	public double? REG_FATOR2 { get; set; }

	public short? REG_FILIAL { get; set; }

	public double? REG_VALOR1 { get; set; }

	public double? REG_VALOR2 { get; set; }

	public double? REG_MINIMO { get; set; }

	public double? REG_GERADOS { get; set; }

	public double? REG_P_TOTAL { get; set; }

	public double? REG_V_TOTAL { get; set; }

	public double? REG_EXTRAS { get; set; }

	public double? REG_P_EXTRAS { get; set; }

	public double? REG_V_EXTRAS { get; set; }

	public double? REG_P_IGNORADOS { get; set; }

	public double? REG_V_IGNORADOS { get; set; }

	public double? REG_TETO { get; set; }

	public DateTime? REG_ATUALIZACAO { get; set; }

	public byte? REG_TIPO { get; set; }

	public short? REG_DIAS_INICIO_UTILIZACAO { get; set; }

	public short? REG_DIAS_VALIDADE { get; set; }

	public bool? REG_UTILIZAR_FILIAL_ORIGEM { get; set; }

	[StringLength(50)]
	public string REG_DESCRICAO { get; set; }

	public byte? REG_TIPO_DESCONTO { get; set; }

	public short? REG_CAMPANHA_CLIENTE { get; set; }

	public short? REG_REGISTRO_TIPO_DESCONTO { get; set; }

	public byte? REG_CLASSIFICACAO_CLIENTE { get; set; }
}
