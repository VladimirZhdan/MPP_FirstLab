using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SPP_Dive_into_IL
{
    public class QuickSort 
    {
        private Comparer cmp = new Comparer();

        public int[] GenerateRandomMass(int len)
        {
            Random rnd = new Random();

            int[] result = new int[len];            
            for(int i = 0; i < len; i++)
            {
                result[i] = rnd.Next();
            }

            return result;
        }

        public void SortMass(int[] mass)
        {
            Sort(mass, 0, mass.Length - 1);            
        }

        private int Partition(int[] array, int start, int end)
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

        private void Sort(int[] array, int start, int end)
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
