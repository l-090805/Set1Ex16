using System;

namespace Set1Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceți 5 numere: ");
            string[] numere = Console.ReadLine().Split(" ");
            int num1 = int.Parse(numere[0]);
            int num2 = int.Parse(numere[1]);
            int num3 = int.Parse(numere[2]);
            int num4 = int.Parse(numere[3]);
            int num5 = int.Parse(numere[4]);

            for (int i = 0; i < 4; i++)  
            {
                if (num1 > num2) (num1, num2) = (num2, num1);
                if (num2 > num3) (num2, num3) = (num3, num2);
                if (num3 > num4) (num3, num4) = (num4, num3);
                if (num4 > num5) (num4, num5) = (num5, num4);
            }

            Console.WriteLine($"Ordinea este: {num1}, {num2}, {num3}, {num4}, {num5}");
        }
    }
}
