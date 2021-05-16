using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoUrna.Models;

namespace ProjetoUrna.Data
{
    public class ProjetoUrnaContext : DbContext
    {
        public ProjetoUrnaContext (DbContextOptions<ProjetoUrnaContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoUrna.Models.Partido> Partido { get; set; }
        public DbSet<ProjetoUrna.Models.Presidente> Presidente { get; set; }
        public DbSet<ProjetoUrna.Models.TotalVoto> TotalVoto { get; set; }

    }
}
