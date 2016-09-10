using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPP_Dive_into_IL
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 1)
            {
                Console.WriteLine("Ошибка! Недостаточное количество параметров");
            }
            else
            {
                int count;
                if (int.TryParse(args[0], out count))
                {
                    if (count > 0)
                    {
                        QuickSort sort = new QuickSort();
                        int[] mass = MassWorker.GenerateRandomMass(count);                        
                        sort.SortMass(mass);
                        MassWorker.OutputMass(mass);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Параметр должен быть положительным числом.");
                    }
                }
                else
                    Console.WriteLine("Ошибка! Параметр должен быть положительным числом.");
            }
        }
    }
}
