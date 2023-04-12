using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Figgle;
using Console = Colorful.Console;

namespace Agence
{
    public partial class Vaisseau
    {
        public string Nom { get; set; }
        public int Capacite { get; set; }
        public double VitesseAct { get; set; }
        public double VitesseMax { get; set; }
        public bool  ValeurOrbite { get; set; }
        public List<Mission> Missions { get; set; }

        public Vaisseau(string nom, int capacite, double vitesseAct, double vitesseMax, bool valeurOrbite)
        {
            Nom = nom;
            Capacite = capacite;
            VitesseAct = vitesseAct;
            VitesseMax = vitesseMax;
            ValeurOrbite = valeurOrbite;
            Missions = new List<Mission>();
        }   

        public void Decollage(string destination,string dateDep) 
        {
      
            if (ValeurOrbite)
            {
                throw new Exception("Le vaisseau est déjà en orbite");
            }
            else
            {
                ValeurOrbite = true;
                Mission mission = new Mission(destination, dateDep);
                Missions.Add(mission);
            }                   

        }

    }

    public partial class Vaisseau
    {
        public void ChangerVitesse(double vitesse)
        {

            if(vitesse > VitesseMax)
            {
                throw new Exception("La vitesse demandé dépasse la vitesse maximale du vaisseau");
            }
            else
            {
                VitesseAct = vitesse;
            }
        }

        public override string ToString()
        {
            string info = $" Nom: {Nom}, Capacité: {Capacite} , Vitesse actuelle : {VitesseAct}, Vitesse Max: {VitesseMax}, Valeur orbite: {ValeurOrbite}";
            return info;
        }
    }
}
