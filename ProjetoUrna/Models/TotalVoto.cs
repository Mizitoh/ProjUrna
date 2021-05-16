using ProjetoUrna.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoUrna.Models
{
    public class TotalVoto
    {
        public int Id { get; set; }
        public DateTime DataVoto { get; set; }

        public Presidente Presidente { get; set; }
        public VotoSituacao Situacao { get; set; }
        public int Soma { get; set; }

        public TotalVoto() { }

        public TotalVoto(int id, DateTime dataVoto, Presidente presidente, VotoSituacao situacao, int soma)
        {
            Id = id;
            DataVoto = dataVoto;
            Presidente = presidente;
            Situacao = situacao;
            Soma = soma;
        }
    }
}
