using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;

namespace projeto1
{
    class MyDbContext:DbContext
    {
      public MyDbContext() : base("name=MyDbContext") { }

    }
}
