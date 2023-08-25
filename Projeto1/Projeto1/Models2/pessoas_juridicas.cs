using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto1.Models2
{
    public class pessoas_juridicas
    {
        [Column("id")]

        public int Id { get; set; }

        [Column("cnpj")]

        public string cnpj { get; set; }

        [Column("cep")]

        public string cep { get; set; }

        [Column("usuario_id")]

        public int usuario_id { get; set; } 


    }
}
