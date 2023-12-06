using Microsoft.Maui.Controls.Compatibility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTPreVenda.db.Models
{
    public class MATERIAIS :DatabaseItem
    {
        [Key]
        [StringLength(14)]
        public string MAT_CODIGO { get; set; }

        [StringLength(12)]
        public string MAT_REFERENCIA { get; set; }

        public short? MAT_COR { get; set; }

        public short? MAT_TAMANHO { get; set; }

        public short? MAT_COLECAO { get; set; }

        //public DateTime? MAT_CADASTRO { get; set; }

        //public byte? MAT_REDE { get; set; }

        //public DateTime? MAT_ATUALIZACAO { get; set; }

        //public bool? MAT_INATIVO { get; set; }

        //public short? MAT_COR_SEQ { get; set; }

        //public byte? MAT_SITE { get; set; }

        [StringLength(14)]
        public string MAT_EAN { get; set; }

        //public double? MAT_DESCONTO_MAXIMO { get; set; }

        public override async Task<object> GetList(uint limint = 1000, IDictionary<string, string> where = null)
        {
            string exp = await ToListExpando(limint, where);
            List<MATERIAIS> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<MATERIAIS>>(exp);
            return list;
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }
    }
}
