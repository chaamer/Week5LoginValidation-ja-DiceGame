using System;

namespace MoreLopps
{
    class Program
    {
        static void Main(string[] args)
        {
            // küsitakse kasutajat ja salasõna
            //Kui õiged siis "Tere tulemast"
            //Muul juhul "proovi uuesti

            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if(userName == "admin" && userPassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");
            }
            else
            {
                Console.WriteLine("Vale, proovi uuesti.");
            }



        }
    }
}
