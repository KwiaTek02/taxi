using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testowa.Obiekty
{
    public class Message
    {
        public void MainScreen()
        {
            Console.WriteLine("WYBIERZ OPCJE:");
            Console.WriteLine();
            Console.WriteLine("1 => LISTA WSZYSTKICH DZIELNIC I TAKSÓWEK");
            Console.WriteLine();
            Console.WriteLine("2 => ZAMÓW TAKSÓWKĘ");
            Console.WriteLine();
            Console.WriteLine("3 => ZAKOŃCZ PROGRAM");
            Console.WriteLine();
            Console.WriteLine("WYBIERZ 1, 2 LUB 3:");
            
        }

        public int Show()
        {
            string input = Console.ReadLine();
            var goodKey = CheckButton(input);
            while (!goodKey)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                Console.WriteLine("Nacisnąłeś nieprawidowy klawisz.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                MainScreen();
                input = Console.ReadLine();
                goodKey = CheckButton(input);
            }
            return int.Parse(input);
        }

        private bool CheckButton(string userInput)
        {
            if (int.TryParse(userInput, out int number))
            {
                if (number >= 1 && number < 4)
                    return true;
            }

            return false;
        }

    }
}
