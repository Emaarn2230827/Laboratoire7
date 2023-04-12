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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FiggleFonts.Standard.Render("     ***** SPACE XX *****"), Color.Yellow);
            bool tours = true;
            Agence spacex = new Agence();   
            while(tours)
            {
                Console.WriteLine("\n ---------- MENU ----------", Color.Green);
                Console.WriteLine("----------------------------", Color.Green);
                Console.WriteLine("1- Engager astronaute");
                Console.WriteLine("2- Améliorer vaisseau");
                Console.WriteLine("3- Enregistrer une mission");
                Console.WriteLine("4- Afficher  missions");
                Console.WriteLine("5- Lancer un vaisseau");
                Console.WriteLine("6- Changer la vitesse du vaisseau");
                Console.WriteLine("7- Valider une mission");
                Console.WriteLine("8- Afficher astronautes");              
                Console.WriteLine("9- Quitter");
                char choix = Console.ReadKey().KeyChar;
                Console.WriteLine();
                try
                {
                    
                    while (choix != '1' && choix != '2' && choix != '3' && choix != '4' && choix != '5' && choix != '6' && choix != '7' && choix != '8' && choix != '9')
                    {
                       
                        throw new Exception("\n #Choix invalide#");
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                switch (choix)
                {
                    case '1':   
                        Console.WriteLine("Entre le type de l'astronaute");
                        string typeAstro = Console.ReadLine();
                        spacex.AjouterAstronaute(typeAstro);
                        break;
                    case '2':
                        spacex.AfficherVaisseau();
                        Console.WriteLine("Entre le numéro du vaisseau à améliorer");
                        bool verifnum = true;
                        int numV = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                           
                            if (numV > spacex.Vaisseaux.Count)
                            {
                                throw new Exception("Numero de vaisseau incorrect");
                                
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            verifnum = false;   
                        }
                        if (verifnum)
                        {
                            spacex.AmeliorerVaisseau(numV);
                        }
                        else
                        {
                            Console.WriteLine("\n Erreur d'amélioration");
                        }
                         
                        break;
                    case '3':
                        Console.WriteLine("Entre les informations sur la mission");
                        Console.WriteLine("Entre le nom de la mission");    
                        string nomM = Console.ReadLine();
                        Console.WriteLine("Voici la liste des planetes, choisi la destination");
                        spacex.AfficherPlanete();
                        string nomDest = Console.ReadLine();
                        Console.WriteLine("Entre la date de départ: ");
                        string dateDep = Console.ReadLine();
                        Console.WriteLine("Entre la date d'arriver: ");
                        string dateAr = Console.ReadLine();
                        Console.WriteLine("Entre le statut de la mission(0 = planifiée, 1 = en cours et 2 = Terminée ) ");
                        int statutM = Convert.ToInt32(Console.ReadLine());    
                        Mission mission = new Mission(nomM,nomDest,dateDep,dateAr, (Statut)statutM);
                        spacex.AjouterMission(mission, spacex.TrouverPlanete(nomDest));
                        break;
                    case '4':
                        spacex.AfficherMission();
                        break;
                    case '5':
                        spacex.AfficherVaisseau();
                        Console.WriteLine("Entre le nom du vaisseau à lancer");
                        string nomvaiss = Console.ReadLine();
                        spacex.AfficherPlanete();
                        Console.WriteLine("Entre la destination");
                        string destination = Console.ReadLine();
                        Console.WriteLine("Entre la date de depart");
                        string datedep = Console.ReadLine();    
                        spacex.TrouverVaisseau(nomvaiss).Decollage(destination,datedep);
                        break;
                    case '6':
                        spacex.AfficherVaisseau();
                        Console.WriteLine("Entre le nom du vaisseau à changer la vitesse");
                        string nomV = Console.ReadLine();
                        Console.WriteLine("Entre la nouvelle vitesse");
                        double vitesse = Convert.ToDouble(Console.ReadLine());
                        spacex.TrouverVaisseau(nomV).ChangerVitesse(vitesse); // comment gerer l'exception . au 5 aussi
                        break;
                    case '7':
                        spacex.AfficherMission();
                        Console.WriteLine("Entre le nom de la mission à valider: ");
                        string nomMi = Console.ReadLine();
                        spacex.TrouverMission(nomMi).CompleterMission();
                        break;
                    case '8':
                        spacex.AfficherAstronaute();
                        break;
                    default:
                        tours = false;
                        break;
                }
               
            }

        }
    }
}
