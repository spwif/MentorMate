using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorMateLogoConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLogo();
        }
        static void PrintLogo()
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int outSide = inputNumber;
            int middleSide = inputNumber;
            int filling = inputNumber;
            int counterUpperside = inputNumber - ((int)inputNumber / 2);

            for (int i = 0; i < counterUpperside; i++)
            {
                string row = new string('-', outSide) + new string('*', filling) + new string('-', middleSide) + new string('*', filling) + new string('-', outSide);
                Console.WriteLine($"{row}{row}");
                outSide--;
                middleSide = middleSide - 2;
                filling += 2;
            }

            filling = inputNumber;
            outSide = (inputNumber - 1) / 2;
            middleSide = 1;
            int middleFilling = (inputNumber * 2) - 1;

            for (int i = 0; i < counterUpperside; i++)
            {
                string row = new string('-', outSide) + new string('*', filling) + new string('-', middleSide) + new string('*', middleFilling) + new string('-', middleSide) + new string('*', filling) + new string('-', outSide);
                Console.WriteLine($"{row}{row}");
                outSide--;
                middleSide += 2;
                middleFilling -= 2;
            }
        }

    }
}

