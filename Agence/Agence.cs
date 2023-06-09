﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Figgle;
using Console = Colorful.Console;

namespace Agence
{
    internal class Agence
    {
        public List<Vaisseau> Vaisseaux { get; set; }
        public List<string> Astronautes { get; set; }  
        public List<Mission> Missions { get; set; }
        public List<Planete> Planetes { get; set; }
        public Agence()
        {
            Vaisseaux = new List<Vaisseau>();  
            Astronautes = new List<string> { "Cosmonaute","Spationaute","Vyomanaute"};
            Missions = new List<Mission>(); 
            Planetes = new List<Planete>();
            Planete plt1 = new Planete("T21",122334,1234564,true,StatutPlanete.pas_exploré);
            Planete plt2 = new Planete("T22",194324,896564,false,StatutPlanete.pas_exploré);
            Planete plt3= new Planete("T23",2232334,993564,true,StatutPlanete.pas_exploré);
            Planete plt4= new Planete("T24",98634,898664,true,StatutPlanete.exploré);
            Planetes.Add(plt1); 
            Planetes.Add(plt2); 
            Planetes.Add(plt3); 
            Planetes.Add(plt4); 
            Vaisseau vs1 = new Vaisseau("space1",8,12000.34,18000,true);
            AjouterVaisseau(vs1);
            Vaisseau vs2 = new Vaisseau("space2", 10, 15800.34, 19000, false);
            AjouterVaisseau(vs2);
            Vaisseau vs3 = new Vaisseau("space3", 9, 12040.34, 16000, false);
            AjouterVaisseau(vs3);
            Mission mission1 = new Mission("Escape from lalora", "T22", "2024-02-09", "2024-10-06", Statut.planifiée);
            AjouterMission(mission1, plt2);
            Mission mission2 = new Mission("Secure millenium", "T21", "2024-06-25", "2025-01-12", Statut.planifiée);
            AjouterMission(mission2, plt1);


        }
        public void AjouterVaisseau(Vaisseau vaisseau)
        {
            Vaisseaux.Add(vaisseau);
        }
        public void AjouterAstronaute(string astro)
        {
            Astronautes.Add(astro); 
        }
        public void AjouterMission(Mission mission, Planete planete)
        {
            if(planete.StatutP == StatutPlanete.pas_exploré)
            {
                Missions.Add(mission);
            }
            else
            {
                Console.WriteLine("\n Cette planète à déjà été explorée", Color.Red);
            }
            
        }
        public void AmeliorerVaisseau(int numVaisseau)
        {
            Vaisseaux[numVaisseau-1].Capacite += 4;
            Vaisseaux[numVaisseau-1].VitesseMax += 1200;
        }
        public void AfficherAstronaute()
        {
            Console.WriteLine("---Liste des Astronautes---", Color.Magenta);
            for(int i=0;i < Astronautes.Count; i++)
            {
                Console.WriteLine(Astronautes[i]);
            }
        }


        public void AfficherVaisseau()
        {
            Console.WriteLine("---Liste des Vaisseaux---", Color.Magenta);
            for (int i=0;i<Vaisseaux.Count;i++)
            {
                Console.WriteLine(Vaisseaux[i].ToString());
            }
        }
        public void AfficherPlanete()
        {
            Console.WriteLine("---Liste des Planètes---", Color.Magenta);
            for (int i = 0; i < Planetes.Count; i++)
            {
                Console.WriteLine(Planetes[i].ToString());
            }
        }
        public Planete TrouverPlanete(string nomP)
        {
            try
            {
                for (int i = 0; i < Planetes.Count; i++)
                {
                    if (Planetes[i].NomPlanete == nomP)
                    {
                        return Planetes[i];
                    }
                }
                throw new Exception("La planète **" + nomP + "** n'a pas été trouvée.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERREUR: " + ex.Message);
                return null;
            }
        }

        public Vaisseau TrouverVaisseau(string nomV)
        {
            try
            {
                for (int i = 0; i < Vaisseaux.Count; i++)
                {
                    if (Vaisseaux[i].Nom == nomV)
                    {
                        return Vaisseaux[i];
                    }
                }
                throw new Exception("Le vaisseau **" + nomV + "** n'a pas été trouvé dans la liste.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERREUR: " + ex.Message);
                return null;
            }
        }


        public void AfficherMission()
        {
            Console.WriteLine("---Liste des Missions---", Color.Magenta);
            for (int i = 0; i < Missions.Count; i++)
            {
                Console.WriteLine(Missions[i].ToString());
            }
        }
        public Mission TrouverMission(string nomM)
        {
            try
            {
                for (int i = 0; i < Missions.Count; i++)
                {
                    if (Missions[i].NomMission == nomM)
                    {
                        return Missions[i];
                    }
                }
                throw new Exception("La mission **" + nomM + "** n'a pas été trouvée dans la liste.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERREUR: " + ex.Message);
                return null;
            }
        }


    }
}
