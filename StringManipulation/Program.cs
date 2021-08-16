using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool prikaziMenu = true;
            while (prikaziMenu)
            {
                prikaziMenu = Menu();
            }
        }

        private static bool Menu()
        {
            Console.Clear();
            Console.WriteLine("Izberi:");
            Console.WriteLine("1. Obrni string");
            Console.WriteLine("2. Odstrani presledke");
            Console.WriteLine("3. Izhod");
            Console.WriteLine("\r\nIzberi možnost: ");

            switch (Console.ReadLine())
            {
                case "1":
                    obrniString();
                    return true;
                case "2":
                    odstraniPresledke();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string zajemiVnos()
        {
            Console.Write("Vnesi stavek (string), ki ga želiš modificirati: ");
            return Console.ReadLine();
        }

        private static void obrniString()
        {
            Console.Clear();
            Console.WriteLine("Obrni string");

            char[] charArray = zajemiVnos().ToCharArray();
            Array.Reverse(charArray);
            prikaziVnos(String.Concat(charArray));
        }

        private static void odstraniPresledke()
        {
            Console.Clear();
            Console.WriteLine("Odstrani presledke");
            prikaziVnos(zajemiVnos().Replace(" ", ""));
        }

        private static void prikaziVnos(string sporocilo)
        {
            Console.WriteLine($"\r\nTvoj modificiran stavek (string) je: {sporocilo}");
            Console.Write("\r\nPritisni Enter za Menu");
            Console.ReadLine();
        } 
    }
}
