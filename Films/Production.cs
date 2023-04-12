using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Films
{
    internal class Production
    {
        public Catalogue Catalogues { get; set; }    
        public Production()
        {
            
            Catalogues = new Catalogue();   
            var acteurs1 = new List<string> { "Ralph", "Ana", "Felipe","Vandam"};
            var genres1 = new List<string> { "Romance", "/Commedie" };
            string synopsis1 = "Le petit djeff est perdu dans la forêt";
            Film film1 = new Film("Booba", "jack", "2002",acteurs1,synopsis1,genres1);
            Catalogues.AjouterFilm(film1);

            var acteurs2 = new List<string> { "Jason statam,", "Dwayne johnson", "kevin hart", "B.Jordan " };
            var genres2 = new List<string> { "Action", "/Drame" };
            string synopsis2 = "Le petit djeff est perdu dans la jungle";
            Film film2 = new Film("THOR", "Daniel", "2006", acteurs2, synopsis2, genres2);
            Catalogues.AjouterFilm(film2);        
        }

        public void AfficherFilm()
        {
            Catalogues.AfficherFilms();
        }

       
        
    }
}
