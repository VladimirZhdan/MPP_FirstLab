using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPP_Dive_into_IL
{
    public class QuickSort 
    {
        private static Comparer cmp = new Comparer();

        public static void SortMass(int[] mass)
        {
            if (mass != null)
                Sort(mass, 0, mass.Length - 1);
            else
                return;
        }

        private static int Partition(int[] array, int start, int end)
        {                    
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (cmp.Compare(array[i], array[end]) < 1)
                {
                    int temp = array[marker]; // swap
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }

        private static void Sort(int[] array, int start, int end)
        {                     
                if (start >= end)
                {
                    return;
                }
                int pivot = Partition(array, start, end);
                Sort(array, start, pivot - 1);
                Sort(array, pivot + 1, end);         
        }
    }
}
