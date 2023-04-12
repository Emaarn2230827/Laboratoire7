using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    public partial class Catalogue
    {
        public void RechercherParTitre(string titre)
        {
            bool search = false;
            int indice = 0;
            for (int i = 0; i < LesFilms.Count; i++)
            {
                if (LesFilms[i].Titre == titre)
                {
                    search = true;
                    indice = i;
                }
            }
            if (search)
            {
                Console.WriteLine($"Voici les informations sur le film ayant pour titre: {titre} ");
                Console.WriteLine(LesFilms[indice].ToString());
            }
            else
            {
                Console.WriteLine("Désolé, ce film n'existe pas");
            }
        }

        public void RechercherParActeur(string acteur)
        {
            bool search = false;
            int indice = 0;
            for (int i = 0; i < LesFilms.Count; i++)
            {
                for (int j = 0; j < LesFilms.Count; j++)
                    if (LesFilms[i].Acteur[j] == acteur)
                    {
                        search = true;
                    }
                indice = i;
            }
            if (search)
            {
                Console.WriteLine($"Voici les informations sur le film ayant pour acteur: {acteur} ");
                Console.WriteLine(LesFilms[indice].ToString());
            }
            else
            {
                Console.WriteLine("Désolé, ce film n'existe pas");
            }
        }
    }
}
