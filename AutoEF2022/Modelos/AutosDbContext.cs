using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AutoEF2022.Modelos
{
    public class AutosDbContext:DbContext
    {
        public AutosDbContext():base("MiConexion") 
        {
            
        }

        public DbSet<Auto> Autos { get; set; }


    }
}
