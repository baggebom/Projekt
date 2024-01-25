using System;
    namespace Projekt
{
     class program
    {
        static void Main(string[]args)
        {

            Console.WriteLine("Välkommen till 21:an");

            string menyval = "0";
            while (menyval != "4")
            {
                Console.WriteLine("välj alternativ");
                Console.WriteLine("1. Spela 21:an");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. spelets regler");
                Console.WriteLine("4. avsluta programmet");
                Console.ReadLine();
            }

                switch (menyval)
                {
                    case "1":
                        Console.WriteLine("Spela omgång 21:an");

                        break;
                    case "2":
                        Console.WriteLine("Visa senaste vinnaren");

                        break;
                    case "3":
                        Console.WriteLine("spelets regler");

                        break;

                    case "4":

                        Console.WriteLine("programmet avslutas");
                        break;

                    default:
                        Console.WriteLine("du valde inte ett giltigt alternativ");
                        break;
                }
                
            
        }
    }
}