using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.Data.Sqlite;
using System.Security.Cryptography.X509Certificates;

namespace Userauthentication
{
    public class userdatacontext : DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource = DataFile.db");
        }

       public DbSet<user> Users { get; set; }

        
    }


}
    
