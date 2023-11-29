using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using PDVNet.Dados.PDV.Modelo.ExtensaoModelos;

namespace PDVNet.Dados.PDV.Modelo;

public class REFERENCIAS_ADICIONAL
{
	//[NotMapped]
	//public List<CampoAdicionalItem> ExtensaoCamposAdicionais { get; set; }

	[Key]
	[Column(Order = 0)]
	public short? RAD_COLECAO { get; set; }

	[Key]
	[Column(Order = 1)]
	[StringLength(12)]
	public string RAD_REFERENCIA { get; set; }

	[Key]
	[Column(Order = 2)]
	public byte RAD_REDE { get; set; }

	public DateTime? RAD_ATUALIZACAO { get; set; }
}
