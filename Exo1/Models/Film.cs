using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Required]
        public int ID { get; set; } //autoincrémenté
        [Required]
        public string Title { get; set; }//unique
        [Required]
        [Range(typeof(DateTime),"1/1/1976","31/12/9999")]
        public DateTime DateDeSortie { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string MainActor { get; set; }
        [Required]
        public GenreFilm GenreFilm { get; set; }

    }
}
