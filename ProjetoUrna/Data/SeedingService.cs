using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoUrna.Models;
using ProjetoUrna.Models.Enums;

namespace ProjetoUrna.Data
{
    public class SeedingService
    {
        private ProjetoUrnaContext _context;
        public SeedingService(ProjetoUrnaContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Partido.Any() || _context.Presidente.Any() || _context.TotalVoto.Any())
            {
                return; //Banco já foi populado
            }

            Partido p1 = new Partido(1, "PT");

            Presidente ps1 = new Presidente(1, "Patifarias", "Soluciones", new DateTime(1998, 4, 21), p1);

            TotalVoto tv1 = new TotalVoto(1, new DateTime(2000, 12, 1), ps1, VotoSituacao.Efetivado, 1);

            _context.Partido.AddRange(p1);
            _context.Presidente.AddRange(ps1);
            _context.TotalVoto.AddRange(tv1);
            _context.SaveChanges();
        }
        
    }
}
