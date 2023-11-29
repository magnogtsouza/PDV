using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PDVNet.Dados.PDV.Modelo;

[Table("DUPLICATABOLETO")]
public class DUPLICATABOLETO
{
	public short DUB_FILIAL { get; set; }

	[StringLength(8)]
	public string DUB_DUPLICATA { get; set; }

	public byte DUB_SERIE { get; set; }

	[StringLength(3)]
	public string DUB_CONTA { get; set; }

	[StringLength(16)]
	public string DUB_DOCUMENTO { get; set; }

	[StringLength(20)]
	public string DUB_NOSSO_NUMERO { get; set; }

	[StringLength(55)]
	public string DUB_LINHA_DIGITAVEL { get; set; }

	[StringLength(50)]
	public string DUB_CODIGO_BARRAS { get; set; }

	[StringLength(15)]
	public string DUB_CODIGO_CEDENTE { get; set; }

	public DateTime? DUB_DATA_DOCUMENTO { get; set; }

	[StringLength(3)]
	public string DUB_CARTEIRA { get; set; }

	[StringLength(20)]
	public string DUB_NOTA_DOC { get; set; }

	[Key]
	[Column(Order = 0)]
	[DatabaseGenerated(DatabaseGeneratedOption.None)]
	public Guid DUB_GUID { get; set; }
}
