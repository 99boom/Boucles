using System.ComponentModel.Design;

namespace Boucles;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consigne générale : faites un commit entre chaque étape !
         */

        // Etape 1 : faire un compteur qui va de 1 à 10

        Console.WriteLine("Step 1 : ");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }


        // Etape 2 : faire un décompte qui va de 5 à 1 puis qui dit "Bonne année !"

        Console.WriteLine("\nStep 2 : ");

        for (int h = 5; h >= 1; h--)
        {
            Console.WriteLine(h);
        }

        Console.WriteLine("HAPPY NEW YEAR !!!");

        // Etape 3 : faire un compteur qui va de -4 à 2

        Console.WriteLine("\nStep 3 : ");

        for (int a = -4; a <= 2; a++)
        {
            Console.WriteLine(a);
        }

        // Etape 4 : faire un compteur qui compte 2 par 2 de 0 à 15

        Console.WriteLine("\nStep 4 : ");

        for (int o = 0; o <= 15; o = o + 2)
        {
            Console.WriteLine(o);
        }

        // Etape 5 : faire une boucle qui se répète à chaque fois que l'utilisateur écrit autre chose que "oui"
        
        Console.WriteLine("\nStep 5 : ");

        Console.WriteLine("Start the program ? : YES/NO");
        string start = Console.ReadLine();

        while (start != "YES")
        {
            Console.WriteLine("Start the program ? : YES/NO");
            start = Console.ReadLine();
        }

        Console.WriteLine("Welcome in the new program !!!");


        /*
         * Après votre dernier commit, faites un push de votre projet pour qu'il soit accessible sur github.com
         */
    }
}