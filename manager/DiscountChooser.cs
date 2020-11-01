using System;
using System.Collections.Generic;
using System.Text;
using Algolab2.manager;
using AlgoLab2.model;

namespace Algo_lab_2.src.manager
{
    class DiscountChooser
    {
        public static decimal FindOptimalPrice(MyList itemsToBuy,decimal discount)
        {
            List<decimal> itemsToEdit = new List<decimal>();
            foreach(int i in itemsToBuy)
            {
                itemsToEdit.Add(i);
            }
            int discountAmount = itemsToEdit.Count / 3;
            HeapSort heapSort = new HeapSort();
            heapSort.Sort(itemsToEdit);
            decimal count = 0;
            decimal discountMultiplier = discount / 100;
            for(int i = 0; i < discountAmount; i++)
            {
                itemsToEdit[i] = itemsToEdit[i] - itemsToEdit[i] * discountMultiplier;
                count += itemsToEdit[i];
            }
            for(int i = discountAmount; i < itemsToEdit.Count; i++)
            {
                count += itemsToEdit[i];
            }
            return count;
        }
    }
}
