using System;

namespace L2_7_Zad_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program sprawdzi czy z 3 podanych długości można stworzyć trójkąt.");
            Console.Write("Podaj pierwszą długość: ");
            double.TryParse(Console.ReadLine(), out double firstLength);
            Console.Write("Podaj pierwszą długość: ");
            double.TryParse(Console.ReadLine(), out double secondLength);
            Console.Write("Podaj pierwszą długość: ");
            double.TryParse(Console.ReadLine(), out double thirdLength);

            if ((thirdLength > firstLength && thirdLength > secondLength && (firstLength + secondLength > thirdLength)) || 
                    (secondLength > firstLength && secondLength > thirdLength && (firstLength + thirdLength > secondLength)) ||
                    (firstLength > secondLength && firstLength > thirdLength && (secondLength + thirdLength > firstLength)))
            {
                Console.WriteLine("Można zbudować trójkąt.");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta.");
            }
        }
    }
}
