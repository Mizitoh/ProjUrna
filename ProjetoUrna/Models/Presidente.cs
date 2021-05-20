using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoUrna.Models
{
    public class Presidente
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Vocês esqueceu de digitar o nome do presidente")]
        [Display(Name = "Presidente")]
        public string NomePresidente { get; set; }
        [Required(ErrorMessage = "Vocês esqueceu de digitar o nome do Vice")]
        [Display(Name = "Vice")]
        public string NomeVice { get; set; }
        [Required(ErrorMessage = "Vocês esqueceu de escolher a data")]
        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DataCadastro { get; set; }
        [Display(Name = "Partido")]
        public Partido Partido { get; set; }
        public int PartidoId { get; set; }
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
