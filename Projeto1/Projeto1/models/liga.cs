using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1.models
{
   public class liga
    {
        [Column("id")]
        public int id { get; set; }

        [Column("nome da liga")]
        public string nome_da_liga { get; set;}

        


    }
}
