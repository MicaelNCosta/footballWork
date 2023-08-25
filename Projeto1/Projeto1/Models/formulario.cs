﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace projeto1.Models
{
    public class formulario
    {
         [Column("id")]
         public int id { get; set; }
       
        [Column("pergunta_1")]
        public bool pergunta_1 { get; set; }

        [Column("pergunta_2")]
        public bool pergunta_2 { get; set; }

        [Column("pergunta_3")]
        public bool pergunta_3 { get; set; }

        [Column("pergunta_4")]
        public bool pergunta_4 { get; set; }

        [Column("pergunta_5")]
        public bool pergunta_5 { get; set; }

        [Column("pergunta_6")]
        public bool pergunta_6 { get; set; }

        [Column("voce")]
        public bool voce { get; set; }

        [Column("usuario_id")]
        public bool usuario_id { get; set; }
    }
}
