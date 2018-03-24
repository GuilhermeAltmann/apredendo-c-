using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PrimeiraWebApp.Models;

namespace PrimeiraWebApp.Data
{
    public class IESContext : DbContext
    {

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }


        public IESContext(DbContextOptions<IESContext> options) : base(options) {

            
        }

     
    }
}
