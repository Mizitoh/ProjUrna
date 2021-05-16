using ProjetoUrna.Data;
using ProjetoUrna.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc.Services
{
    public class PartidoService
    {
        private readonly ProjetoUrnaContext _context;

        public PartidoService(ProjetoUrnaContext context)
        {
            _context = context;
        }

        public List<Partido> FindAll()
        {
            return _context.Partido.OrderBy(x => x.Nome).ToList();
        }
    }
}