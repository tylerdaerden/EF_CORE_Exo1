using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1.Models
{
    public enum GenreFilm
    {
        Action, Aventure, Romantique, Comédie, Thriller, Horreur, Indépendant, BioPic, Historique
    }
    public class Film
    {
        public int ID { get; set; } //autoincrémenté
        public string Title { get; set; }//unique
        public DateTime Director { get; set; }
        public string MainActor { get; set; }
        public GenreFilm GenreFilm { get; set; }

    }
}
