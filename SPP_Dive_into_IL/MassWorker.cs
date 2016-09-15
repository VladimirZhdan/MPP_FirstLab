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
            if (mass != null)
            {
                for (int i = 0; i < mass.Length; i++)
                {
                    Console.WriteLine(mass[i]);
                }
            }
            else
                return;                            
        }

        public static int[] GenerateRandomMass(int len)
        {
            if (len > 0)
            {
                Random rnd = new Random();

                int[] result = new int[len];
                for (int i = 0; i < len; i++)
                {
                    result[i] = rnd.Next(-100, 100);
                }

                return result;
            }
            else
                return null;            
        }
    }
}
