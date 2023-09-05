using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto1.models
{
    public class Time
    {
        [Column("id")]
        public int id { get; set; }

        [Column("time")]
        public string time { get; set; }

        [Column("ligas_id")]
        public int ligas_id { get; set; }

        [Column("estatisticas_id")]
        public string estatisticas_id { get; set; }
    }

}
