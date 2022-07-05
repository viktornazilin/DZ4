using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 25
            /*
            Console.WriteLine("Задача 25. Введите число");
            string numberInput = Console.ReadLine();
            double number = Convert.ToDouble(numberInput);

            Console.WriteLine("Введите степень числа");
            string stepenInput = Console.ReadLine();
            double stepen = Convert.ToDouble(stepenInput);

            StepenChisla(number, stepen);
            Console.WriteLine();
            

            // Задача 27

            Console.WriteLine("Задача 27");

            Console.WriteLine("Введите число.");

            string input27 = Console.ReadLine();
            Console.WriteLine(SummaChiselVChisle(input27));

            */


            // Задача 29

            int[] arrayTest = SozdanieMassiva(4);

            Console.WriteLine(arrayTest[4]);

        }

        static double StepenChisla(double telo, double stepen)
        {
            if (stepen >= 1)
            {
                int count = 1;
                double result = telo;

                while (count < stepen)
                {
                    result *= telo;
                    count++;
                    
                }
                Console.WriteLine(result);
                return result;
            }
            else if (stepen == 0)
            {
                double result = 1;
                Console.WriteLine(result);
                return result;
            }
            else if (stepen < 1 && stepen > 0)
            {
                double result = Math.Pow(telo, stepen);
                Console.WriteLine(result);
                return result;
            }
            else if (stepen < -1)
            {
                double result = telo;
                int count = 1;

                while (count < (stepen * (-1)))
                {
                    result *= telo;
                    count++;
                    Console.WriteLine(result);
                }

                result = 1 / result;
                return result;
            }
            else
            {
                double result = Math.Pow(telo, stepen);
                Console.WriteLine(result);
                return result;
            }
        }

        static int SummaChiselVChisle(string userInput)
        {
            int[] number = userInput.ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();
            int count = 0;
            int index = 0;
            int result = 0;

            while (count < number.Length)
            {
                
                result += number[index];

                count++;
                index++;

                
            }

            return result;
        }

        static int[] SozdanieMassiva(int numberQuantity)
        {
            
            int[] array = new int[8];
            Random rand = new Random();

            for (int y = 0; y < numberQuantity; y++)
            {
                array[y] = rand.Next(1, 100);
                Console.WriteLine(array[y]);
            }

            return array;
            
        }
    }
}