using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agence
{
    public enum Statut
    {
        planifiée,
        en_cours,
        terminée
    }
    public partial class Mission
    {
        public string NomMission { get; set; }
        public string Destination { get; set; }
        public string DateDep { get; set; }
        public string DateArr{ get; set; }
        public Statut StatutM{ get; set; }

        public Mission(string nomMission, string destination, string dateDep, string dateArr, Statut statutM)
        {
            NomMission = nomMission;
            Destination = destination;
            DateDep = dateDep;
            DateArr = dateArr;
            StatutM = statutM;
        }
        public Mission(string destination, string dateDep)
        {
            NomMission = null;
            Destination = destination;
            DateDep = dateDep;
            DateArr = null;
            StatutM = Statut.en_cours;
        }
    }

    public partial class Mission
    {
        public void CompleterMission()
        {
            StatutM = Statut.terminée;
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.WriteLine("La mission a été achevé");
            Console.ResetColor();   
        }

        public override string ToString()
        {
            string info = $"Nom mission: {NomMission}, Destination: {Destination} Date de depart: {DateDep} Date d'arriver: {DateArr} Statut Mission: {StatutM}";
            return info;
        }

    }

}
