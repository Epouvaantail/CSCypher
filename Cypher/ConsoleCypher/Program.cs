using System;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleCypher
{
    class Cypher
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            bool isNotTerminated = true;
            while (isNotTerminated)
            {
                Console.Clear();
                Console.WriteLine(" ________      ___    ___ ________  ___  ___  _______   ________     \r\n|\\   ____\\    |\\  \\  /  /|\\   __  \\|\\  \\|\\  \\|\\  ___ \\ |\\   __  \\    \r\n\\ \\  \\___|    \\ \\  \\/  / | \\  \\|\\  \\ \\  \\\\\\  \\ \\   __/|\\ \\  \\|\\  \\   \r\n \\ \\  \\        \\ \\    / / \\ \\   ____\\ \\   __  \\ \\  \\_|/_\\ \\   _  _\\  \r\n  \\ \\  \\____    \\/  /  /   \\ \\  \\___|\\ \\  \\ \\  \\ \\  \\_|\\ \\ \\  \\\\  \\| \r\n   \\ \\_______\\__/  / /      \\ \\__\\    \\ \\__\\ \\__\\ \\_______\\ \\__\\\\ _\\ \r\n    \\|_______|\\___/ /        \\|__|     \\|__|\\|__|\\|_______|\\|__|\\|__|\r\n             \\|___|/                                                 \r\n                                                                     \r\n                                                                     ");
                Console.WriteLine("=== MENU PRINCIPAL ===");
                Console.WriteLine("1. Chiffrer");
                Console.WriteLine("2. Dechiffrer");
                Console.WriteLine("3. Quitter");
                Console.Write("Choisissez une option (1-3) : ");

                string choice = Console.ReadLine()!;

                switch (choice)
                {
                    case "1":
                        Ceasar();
                        break;

                    case "2":
                        Console.WriteLine("test");
                        break;

                    case "3":
                        isNotTerminated = false;
                        break;

                    default:
                        Console.WriteLine("Option invalide. Veuillez réessayer.");
                        break;
                }
            }
        }

        public static string Ceasar()
        {
            Console.Write("Quel mot désirez-vous chiffrer ? \nMot:");

            string? word = Console.ReadLine();
            word = word!.ToLower();
            //Task.Delay(3000).Wait();
            Console.Write("Entrez un chiffre entre 1 et 25 ? \nClé:");
            int key = int.Parse(Console.ReadLine()!);
            //Task.Delay(3000).Wait();
            Console.Clear();
  
            string result = "";
            foreach (char letter in word)
            {
                result += DecalerLettre(letter, key);

            }
            Console.WriteLine("Votre mot chiffré:" + " " + result);
            Task.Delay(3000).Wait();

            return result;

        }

        public static char DecalerLettre(char letter, int key)
        {
            if (char.IsLetter(letter))
            {
                char baseLettre = char.IsUpper(letter) ? 'A' : 'a';
                return (char)((((letter - baseLettre) + key) % 26 + 26) % 26 + baseLettre);
            }
            return letter;
        }

    }
}