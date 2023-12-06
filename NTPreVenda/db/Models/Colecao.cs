using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTPreVenda.db.Models
{
    public class Colecao : DatabaseItem
    {
        public Colecao() : base("COLECOES")
        {
        }

        [Key]
        public short COL_CODIGO { get; set; }

        [StringLength(30)]
        public string COL_DESCRICAO { get; set; }

        //public byte? COL_REDE { get; set; }

        //public bool? COL_INATIVO2 { get; set; }

        //public DateTime? COL_ATUALIZACAO { get; set; }

        //[StringLength(8)]
        //public string COL_MATRICULA { get; set; }



        public override async Task<object> GetList(uint limint = 1000, IDictionary<string, string> where = null)
        {
            string exp = await ToListExpando(limint, where);
            List<Colecao> list = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Colecao>>(exp);
            return list;
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }
    }
}
