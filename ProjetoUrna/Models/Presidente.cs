using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoUrna.Models
{
    public class Presidente
    {
        public int Id { get; set; }
        public string NomePresidente { get; set; }
        public string NomeVice { get; set; }
        public DateTime DataCadastro { get; set; }

        public Partido Partido { get; set; }
        public ICollection<TotalVoto> Votos { get; set; } = new List<TotalVoto>();


        public  Presidente() { }

        public Presidente(int id, string nomePresidente, string nomeVice, DateTime dataCadastro, Partido partido)
        {
            Id = id;
            NomePresidente = nomePresidente;
            NomeVice = nomeVice;
            DataCadastro = dataCadastro;
            Partido = partido;
        }

        public void AddVoto (TotalVoto tv)
        {
            Votos.Add(tv);
        }

        public int TotalVotos (DateTime Inicial, DateTime Final)
        {
            return Votos.Where(tv => tv.DataVoto >= Inicial && tv.DataVoto <= Final).Sum(tv => tv.Soma);
        }
    }
}
