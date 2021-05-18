using ProjetoUrna.Data;
using ProjetoUrna.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public Presidente FindbyId(int id)
        {
            return _context.Presidente.Include(obj => obj.Partido).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Presidente.Find(id);
            _context.Presidente.Remove(obj);
            _context.SaveChanges();
        }
    }
}
