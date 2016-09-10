using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPP_Dive_into_IL
{
    public static class MassWorker
    {
        public static void OutputMass(int[] mass)
        {
            for(int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i]);
            }
        }

        public static int[] GenerateRandomMass(int len)
        {
            Random rnd = new Random();

            int[] result = new int[len];
            for (int i = 0; i < len; i++)
            {
                result[i] = rnd.Next(-100, 100);
            }

            return result;
        }
    }
}
