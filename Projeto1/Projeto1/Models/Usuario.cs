﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace projeto1.Models
{
   public class Usuario
    {
        [Column("id")]
        public int Id { get; set;}

        [Column("nome")]
        public string Nome { get; set;}

        [Column("endereco")]
        public string Endereco { get; set;}

        [Column("telefone")]
        public string Telefone { get; set;}

        [Column("email")]
        public string Email { get; set;}

        [Column("senha")]
        public string Senha { get; set;}
    }
}
