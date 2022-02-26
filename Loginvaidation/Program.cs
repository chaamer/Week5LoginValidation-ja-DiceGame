using System;

namespace Loginvaidation
{
    class Program
    {
        static void Main(string[] args)
            
        {
            // küsitakse kasutajat ja salasõna
            //Kui õiged siis "Tere tulemast"
            //Muul juhul "proovi uuesti
            //Kolm katset
            int i = 0;

            while (i < 3)
            { 
            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if (userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
                    break;
            }
            else
            {
                i++;
                Console.WriteLine($"Vale, proovi uuesti. {3 - i} katset on jäänud.");
            }
            }

        }

    }
}
