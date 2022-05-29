using System;

namespace homework008
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int step = 7;
            int max = 100;

            for (firstNumber = 5; firstNumber < max; firstNumber += step)
            //for так как легче задать условие для последовательности цифр.
            {
                Console.WriteLine(firstNumber);
            }
        }
        }       
    }