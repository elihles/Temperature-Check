using System;

namespace practiceArraysforsupp
{
    internal class Program
    {
        const int NumDays = 10;
        static void Main(string[] args)
        {
            int temp1, temp2;

            temp1 = 0;
            temp2 = 0;

            int[] list = new int[NumDays];
            for (int i = 0; i < NumDays; i++)
            {
                list[i] = GetValidTemperature(i + 1);
            }

            int warmest = GetWarmest(temp1, temp2);
            ReadIntegers(list);
            double average = GetAvgTemperature(list);
            int count = CountWarmDays(list);
            DisplayList(list);
            Console.WriteLine();
            Console.WriteLine("The warmest Temperature is {0} : ", warmest);
            Console.WriteLine("The average temperature is {0} :", average);
            Console.WriteLine("The number of warm days is {0} :", count);
            Console.WriteLine("All temperatures in the array are : {0}", list);
            Console.ReadLine();
        }

        static int GetValidTemperature(int dayNum)
        {
            int temperature;
            do
            {
                Console.Write("Enter temperature for day {0}: ", dayNum);
                temperature = int.Parse(Console.ReadLine());

            } while (temperature <= 0 || temperature >= 45);
            return temperature;
        }

        static int GetWarmest(int temp1, int temp2)
        {
            return Math.Max(temp1, temp2);
        }

        static void ReadIntegers(int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = GetValidTemperature(i + 1);
            }
        }

        static double GetAvgTemperature(int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            double average = sum / (double)list.Length;
            return average;
        }

        static int CountWarmDays(int[] list)
        {
            int count = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i] > 30)
                {
                    count++;
                }
            }
            return count;
        }

        static void DisplayList(int[] list)
        {
            Console.Write("All temperatures in the array: ");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
