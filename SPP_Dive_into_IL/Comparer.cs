using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPP_Dive_into_IL
{
    public class Comparer : IComparer<int>
    {        
        public int Compare(int x, int y)
        {
            if (x > y)
                return 1;
            else
                if (x < y)
                    return -1;
                else
                    return 0;            
        }
    }
}
