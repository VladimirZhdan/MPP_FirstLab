using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPP_Dive_into_IL
{
    class Worker 
    {
        int[] GenerateRandomMass(int len)
        {
            Random rnd = new Random();

            int[] result = new int[len];            
            for(int i = 0; i < len; i++)
            {
                result[i] = rnd.Next();
            }

            return result;
        }
    }
}
