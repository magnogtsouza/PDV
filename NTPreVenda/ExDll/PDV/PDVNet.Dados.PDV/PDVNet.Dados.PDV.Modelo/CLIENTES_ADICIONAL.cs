using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//using PDVNet.Dados.PDV.Modelo.ExtensaoModelos;

namespace PDVNet.Dados.PDV.Modelo;

public class CLIENTES_ADICIONAL
{
	[Key]
	[StringLength(16)]
	public string CAD_CODIGON { get; set; }

	public DateTime? CAD_ATUALIZACAO { get; set; }

	//[NotMapped]
	//public List<CampoAdicionalItem> ExtensaoCamposAdicionais { get; set; }
}
