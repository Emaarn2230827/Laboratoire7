using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    enum StatutPlanete
    {
        pas_exploré,
        exploré
    }
    internal class Planete
    {
        public string NomPlanete { get; set; }
        public double TaillePlanete { get; set; }
        public double DistancePlaTerre { get; set; }
        public  bool Atmosphere { get; set; }
        public  StatutPlanete StatutP{ get; set; }

        public Planete(string nomPlanete, double taillePlanete, double distancePlaTerre, bool atmosphere,StatutPlanete statut)
        {
            NomPlanete = nomPlanete;
            TaillePlanete = taillePlanete;
            DistancePlaTerre = distancePlaTerre;
            Atmosphere = atmosphere;
            StatutP = statut;   
        }
        public Planete()
        {
            NomPlanete = null;
            TaillePlanete = 0;
            DistancePlaTerre = 0;
            Atmosphere = false;
            StatutP = StatutPlanete.pas_exploré;
        }

        public void VerifierExploration()
        {
            if (StatutP == StatutPlanete.exploré)            {
                throw new Exception("Cette planète a déjà été explorée");
            }
            else
            {
                StatutP = StatutPlanete.exploré;
                Console.WriteLine($"La planète {NomPlanete} situé à {DistancePlaTerre} de la terre vient d'être exploré");
            }
        }

        public override string ToString()
        {

            string info = $" Nom planete: {NomPlanete}, Taille: {TaillePlanete}, Distance avec la terre: {DistancePlaTerre}, Atmosphere: {Atmosphere}";
            return info;    
        }
    }
}
