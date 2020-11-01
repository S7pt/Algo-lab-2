using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;

namespace AlgoLab2.model
{
    public class MyList :IEnumerable
    {
        private int[] listArray = { };
        private int counter;

        public MyList()
        {
            counter = 0;
        }
        public IEnumerator GetEnumerator()
        {
            return listArray.GetEnumerator();
        }

        public void Add(int element)
        {
            Array.Resize(ref listArray,counter+1);
            listArray[counter] = element;
            counter++;
        }

        public int Length()
        {
            return counter + 1;
        }

        public void RemoveAt(int index)
        {
             Array.Clear(listArray,index,1);
        }

        public override string ToString()
        {
            return string.Join(" ", listArray);
        }
    }
}