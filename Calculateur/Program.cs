using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculateur
{
    internal class Program
    {
        static int VerifierNbre( int num)
        {
            bool verif = true;
            while (verif)
            {
                try
                {
                    string nbre1 = Console.ReadLine();

                    if (!int.TryParse(nbre1, out num))
                    {
                        throw new Exception("Vous n'avez pas entrer un entier");
                    }
                    else
                    {
                        verif = false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return num;
        }

        static void Main(string[] args)
        {
            // le premier nombre doit il etre plus grand que le second
            Console.WriteLine("Entre le premier nombre pour la division");
            int num1 = VerifierNbre(0);
            Console.WriteLine("Entre le deuxieme nombre pour la division");
            int num2 = VerifierNbre(0);

            Calculateur calculateur = new Calculateur();
            try
            {
                int nbre = calculateur.Diviser(num1, num2);
                Console.WriteLine("Le resultat de la division est: "+ nbre);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.WriteLine("Entre le premier nombre pour la multiplication");
            int num3 = VerifierNbre(0);
            Console.WriteLine("Entre le deuxieme nombre pour la multiplication");
            int num4 = VerifierNbre(0);
            Console.WriteLine("Le resultat de la multiplication est: " + calculateur.Multiplier(num3, num4));


        }
    }
}
