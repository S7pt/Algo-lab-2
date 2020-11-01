using System;
using System.Collections.Generic;
using System.Text;
using Algo_lab_2.src.manager;
using AlgoLab2.manager;

namespace Algolab2.manager
{
    class HeapSort
    {
        private int swaps;
        private int comparisons;

        public HeapSort()
        {
            swaps = 0;
            comparisons = 0;
        }
        public void Sort(List<decimal> givenList)
        {
            int n = givenList.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
                HeapifyDescending(givenList, n, i);

            for (int i = n - 1; i > 0; i--)
            {
                swaps++;
                Utilities.Swap(givenList, i, 0);
                HeapifyDescending(givenList, i, 0);
            }
        }
        void HeapifyDescending(List<decimal> givenList, int heapSize, int root)
        {
            int least = root; 
            int leftBranch = 2 * root + 1;  
            int rightBranch = 2 * root + 2;
            comparisons += 2;
            if (leftBranch < heapSize && givenList[leftBranch] < givenList[least])
                least = leftBranch;
            comparisons += 2;
            if (rightBranch < heapSize && givenList[rightBranch] < givenList[least])
                least = rightBranch;
 
            if (least != root)
            {
                swaps++;
                Utilities.Swap(givenList, least, root);
                HeapifyDescending(givenList, heapSize, least);
            }
        }
        public override string ToString()
        {
            return "swaps: " + swaps + " comparisons: " + comparisons;
        }
    }
}
