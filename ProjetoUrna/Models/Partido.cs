using System.Collections;
using System.Collections.Generic;

namespace ProjetoUrna.Models
{
    public class Partido
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Presidente> Presidente { get; set; } = new List<Presidente>();
    
        public Partido() { }

        public Partido(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddPresidente(Presidente presidente)
        {
            Presidente.Add(presidente);
        }

    }
}
