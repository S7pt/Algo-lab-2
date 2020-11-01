using Algo_lab_2.src.manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using AlgoLab2.model;

namespace AlgoLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList items=new MyList();
            decimal discount;
            using (StreamReader reader = new StreamReader("D:/VSprojects/AlgoLab2/AlgoLab2/discnt_in.txt"))
            {
                string buffer = reader.ReadLine();
                string[] bufferArray = buffer.Split(' ');
                foreach (var unit in bufferArray)
                {
                    items.Add(int.Parse(unit));
                }

                buffer = reader.ReadLine();
                discount = decimal.Parse(buffer);
            }

            if (discount < 0)
            {
                discount = Math.Abs(discount);
            }

            decimal optimalSum = DiscountChooser.FindOptimalPrice(items, discount);
            using (StreamWriter writer = new StreamWriter("D:/VSprojects/AlgoLab2/AlgoLab2/discnt_out.txt"))
            {
                writer.WriteLine(optimalSum);
            }
        }
    }
}
