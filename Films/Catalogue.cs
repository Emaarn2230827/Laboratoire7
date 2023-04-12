using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{

    public partial class Catalogue
    { 
        List<Film> LesFilms { get; set; }  

        public Catalogue()
        {
            LesFilms = new List<Film>();
        }

        public void AjouterFilm(Film film)
        {
            LesFilms.Add(film);
        }

        public void SupprimerFilm(string nomfilm)
        {
            for (int i = 0; i < LesFilms.Count; i++)
            {
                if (LesFilms[i].Titre == nomfilm)
                {
                    LesFilms.RemoveAt(i);
                    break;
                }
            }
        }

        public void AfficherFilms()
        {
            Console.WriteLine("Voici la liste des films");
            for(int i = 0; i < LesFilms.Count; i++)
            {
                Console.WriteLine(LesFilms[i].ToString());    
            }
        }

    }

    


}
