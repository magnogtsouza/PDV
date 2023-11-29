using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PDVNet.Dados.PDV.Modelo;

public class MARKETPLACEPRODUTOCATEGORIA
{
	[Key]
	public int MPC_CODIGO { get; set; }

	public byte? MPC_PLATAFORMA { get; set; }

	[StringLength(12)]
	public string MPC_REFERENCIA { get; set; }

	public byte? MPC_REDE { get; set; }

	[StringLength(12)]
	public int? MPC_CATEGORIA_PLATAFORMA_ID { get; set; }

	public DateTime? MPC_ATUALIZACAO { get; set; }

	public virtual ICollection<MARKETPLACEPRODUTOCATEGORIAATRIBUTO> MARKETPLACEPRODUTOCATEGORIAATRIBUTO { get; set; }
}
