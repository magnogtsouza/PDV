using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class VEICULO
{
	[Key]
	public short? VEI_CODIGO { get; set; }

	[StringLength(50)]
	public string VEI_DESCRICAO { get; set; }

	[StringLength(8)]
	public string VEI_PLACA { get; set; }

	[StringLength(11)]
	public string VEI_RENAVAM { get; set; }

	public int? VEI_TARA { get; set; }

	public int? VEI_CAPACIDADE_KG { get; set; }

	public short? VEI_CAPACIDADE_M3 { get; set; }

	public byte? VEI_TIPO_RODADO { get; set; }

	public byte? VEI_TIPO_CARROCERIA { get; set; }

	public byte? VEI_UF { get; set; }

	public DateTime? VEI_CADASTRO { get; set; }

	public DateTime? VEI_ATUALIZACAO { get; set; }

	[StringLength(8)]
	public string VEI_MATRICULA { get; set; }

	public bool? VEI_INATIVO { get; set; }

	public virtual ESTADO ESTADO { get; set; }

	[NotMapped]
	public string ExtensaoUsuarioNome { get; set; }
}
