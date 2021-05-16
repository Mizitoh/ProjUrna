using ProjetoUrna.Data;
using ProjetoUrna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoUrna.Services
{
    public class PresidenteService
    {
        private readonly ProjetoUrnaContext _context;

        public PresidenteService(ProjetoUrnaContext context)
        {
            _context = context;
        }

        public List<Presidente> FindAll()
        {
            return _context.Presidente.ToList();
        }

        public void Insert(Presidente obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
