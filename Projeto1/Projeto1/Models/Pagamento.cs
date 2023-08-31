using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;

namespace projeto1.Models
{
    public class Pagamento
    {
        [Column("id")]
        
        public int id { get; set;  }

        [Column("usuario_id")]

        public int usuario_id { get; set; }

        [Column("data_pagamento")]

        public string data_pagamento { get; set; }


        [Column("cpf_pagamento")]

        public int cpf_pagamento { get; set; }

        [Column("cnpj_paagamento")]

        public int cnpj_pagamento { get; set; }

        [Column("numero_cartao")]

        public int numero_cartao { get; set; }

        [Column("senha_cartao")]

        public int senha_cartao { get; set; }

        [Column("data_valide")]

        public int data_validade { get; set; }

        [Column("cvc")]

        public int cvc { get; set; }

        [Column("nome_titular")]

        public int nome_titular { get; set; }
    }
}
