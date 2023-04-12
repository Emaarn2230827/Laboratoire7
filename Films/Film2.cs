using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public partial class Film
    {
        public string Synopsis { get; set; }
        public List<string> Genres { get; set; }

        public Film(string titre, string directeur, string annee, List<string> acteur, string synopsis, List<string> genre)
        {
            Titre = titre;
            Directeur = directeur;
            Annee = annee;
            Acteur = acteur;
            Synopsis = synopsis;
            Genres = genre;
        }

        public override string ToString()
        {
            string info = $" Titre: {Titre} \n Directeur: {Directeur} \n Annee: {Annee} \n" +
                              $"Acteur: ";
            for (int i = 0; i < Acteur.Count; i++)
            {
                info += Acteur[i]+"  ";
            }
            info += $"\n Synopsis : {Synopsis} \n Genres: ";
            for (int i = 0; i < Genres.Count; i++)
            {
                info += Genres[i];
            }
            
            return info;
        }
        
    }
}
