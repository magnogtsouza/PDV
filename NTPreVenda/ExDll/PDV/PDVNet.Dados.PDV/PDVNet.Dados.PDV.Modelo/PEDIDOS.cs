using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class PEDIDOS
{
	public List<ITENSPEDIDO> ExtensaoItensPedido { get; set; }

	[Key]
	[StringLength(6)]
	public string PED_PEDIDO { get; set; }

	[StringLength(6)]
	public string PED_FORNECEDOR { get; set; }

	public DateTime? PED_DATA { get; set; }

	[StringLength(100)]
	public string PED_OBSERVACAO { get; set; }

	public DateTime? PED_CADASTRO { get; set; }

	public DateTime? PED_INICIO_ENTREGA { get; set; }

	public DateTime? PED_FIM_ENTREGA { get; set; }

	public double? PED_MINIMO { get; set; }

	public short? PED_CONDICAO { get; set; }

	[Column(TypeName = "ntext")]
	public string PED_TECNICAS { get; set; }

	public DateTime? PED_BAIXA { get; set; }

	[StringLength(8)]
	public string PED_MATRICULA { get; set; }

	public DateTime? PED_ATUALIZACAO { get; set; }

	public DateTime? PED_PREVISAO_ORIGINAL { get; set; }

	public byte? PED_ATACADO { get; set; }

	public byte? PED_TABELA { get; set; }

	public short? PED_REPRESENTANTE { get; set; }

	public byte? PED_STATUS_NOVO { get; set; }

	public double? PED_DESCONTO { get; set; }

	public bool PED_TIPO_DESCONTO { get; set; }

	[StringLength(15)]
	public string PED_CODIGO_EXTERNO { get; set; }
}
