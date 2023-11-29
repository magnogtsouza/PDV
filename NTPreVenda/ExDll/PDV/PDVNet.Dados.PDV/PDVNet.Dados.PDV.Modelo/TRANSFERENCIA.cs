using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

public class TRANSFERENCIA
{
	[Key]
	[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
	public int TRA_ID { get; set; }

	[StringLength(20)]
	public string TRA_DOC { get; set; }

	public bool? TRA_TIPO { get; set; }

	public DateTime? TRA_DATA_TRANSACAO { get; set; }

	public short? TRA_ORIGEM { get; set; }

	public short? TRA_DESTINO { get; set; }

	public int? TRA_ID_RESPOSTA { get; set; }

	public short? TRA_STATUS { get; set; }

	public bool? TRA_TRAVADO { get; set; }

	public bool? TRA_BATIMENTO { get; set; }

	public DateTime? TRA_DATA_BATIMENTO { get; set; }

	[StringLength(100)]
	public string TRA_OBSERVACAO { get; set; }

	public DateTime? TRA_CADASTRO { get; set; }

	[StringLength(8)]
	public string TRA_MATRICULA { get; set; }

	public DateTime? TRA_ATUALIZACAO { get; set; }

	[StringLength(6)]
	public string TRA_CODIGO_ANTIGO { get; set; }

	public virtual ICollection<TRANSFERENCIAITEM> TRANSFERENCIAITEM { get; set; }
}
