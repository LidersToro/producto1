using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace producto1.Models
{
    public class DataContexts:DbContext
    {
        public DataContexts():base("DefaulConnection")
        {

        }

        public System.Data.Entity.DbSet<producto1.Models.Producto> Productoes { get; set; }
    }
}