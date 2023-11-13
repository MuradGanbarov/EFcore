using EF_Core.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core.DAL
{
    internal class AppDataBase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=DESKTOP-K4K2IM1;database=EFtask;trusted_connection=true;integrated security=true;encrypt=false;");
        }

        public DbSet<Student> Students { get; set; }

    }
}
