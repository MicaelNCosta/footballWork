using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto1.Models
{
    public class Pagamento
    {
        [Column("id")]
        
        public int id { get; set;  }
    }
}
