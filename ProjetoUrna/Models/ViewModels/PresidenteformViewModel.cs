using System.Collections.Generic;

namespace ProjetoUrna.Models.ViewModels
{
    public class PresidenteformViewModel
    {
        public Presidente Presidente { get; set; }
        public ICollection<Partido> Partidoes { get; set; }
    }
}


